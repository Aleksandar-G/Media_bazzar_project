<?php

namespace App\Http\Controllers;

use App\Leave;
use Carbon\Carbon;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\DB;

use App\Supervisor;
use App\Worker;
use App\WorkShift;
use Facade\FlareClient\Http\Response;

class WorkshiftController extends Controller
{
  public static function index()
  {
    $role = Auth::user()->role;
    $workers = static::GetManagedWorkers($role);

    if ($role == "Supervisor" || $role == "Manager" || $role == "Administrator") {
      return view('workshift', ['workers' => $workers, "id" => $workers->first()->id]);
    }

    return view('workshift_view', [
      'id' => Auth::user()->id,
      'worker_id' => Worker::firstWhere('user_id',  Auth::user()->id)->id
    ]);
  }

  public static function show($id)
  {
    $role = Auth::user()->role;
    if ($role == "Worker") {
      return redirect("/workshifts");
    }

    $workers = static::GetManagedWorkers($role);

    return view('workshift', ['workers' => $workers, 'id' => $id]);
  }

  public static function store(Request $request)
  {
    $worker = Worker::firstWhere('user_id', Auth::user()->id);
    WorkShift::find($request->input('workshift_id'))->workers()->syncWithoutDetaching($worker);

    return response()->json(['success' => 'success'], 200);
  }

  public static function getEvents($id)
  {
    $worker = Worker::firstWhere('user_id', $id);

    $userWorkShifts = $worker->workShifts()
      ->withCount('workers as workers_assigned')
      ->get();

    $events = array();

    foreach ($userWorkShifts as $workShift) {
      $event = static::transformToEvent($workShift);
      array_push($events, $event);
    }

    $availableWorkshifts = WorkShift::withCount('workers as workers_assigned')
      ->whereHas('workers', function ($q) {
        $q->havingRaw('workers_assigned < workers_needed');
      })->where('date', '>=',  Carbon::today())
      ->get()
      ->reject(function ($workShift) use (&$userWorkShifts) {
        return $userWorkShifts->contains($workShift);
      });

    foreach ($availableWorkshifts as $workShift) {
      $event = static::transformToEvent($workShift);
      $event['classNames'] = ['available-shift'];
      $event['workshift_id'] = $workShift->id;
      $event['clickable'] = true;
      array_push($events, $event);
    }

    $leaves = $worker->leaves;

    foreach ($leaves as $leave) {
      $event = [
        'start' => $leave->from,
        'end' => $leave->to,
        'allDay' => true,
        'title' => 'Off',
        'backgroundColor' => '#939393'
      ];
      array_push($events, $event);
    }

    return (json_encode($events));
  }

  private static function GetManagedWorkers($role)
  {
    $workers = Worker::all();

    if ($role == 'Supervisor') {
      $supervisor = Supervisor::where('user_id', (Auth::user()->id))->first();

      $workers = $workers->reject(function ($worker) use (&$supervisor) {
        return $supervisor->department_id != $worker->department_id;
      });
    }

    return $workers->map(function ($worker) {
      return $worker->user;
    });
  }

  private static function transformToEvent($workShift)
  {
    $event = array();
    $event['title'] = "Shift for $$workShift->wage\n" . $workShift->workers_assigned . "/" . $workShift->workers_needed . " workers";

    switch ($workShift->shift) {
      case 'Morning':
        $event['start'] = $workShift->date . "T" . "08:00";
        $event['end'] = $workShift->date . "T" . "12:00";
        break;
      case 'Afternoon':
        $event['start'] = $workShift->date . "T" . "12:00";
        $event['end'] = $workShift->date . "T" . "16:00";
        break;
      case 'Evening':
        $event['start'] = $workShift->date . "T" . "16:00";
        $event['end'] = $workShift->date . "T" . "20:00";
        break;
      default:
        $event['start'] = $workShift->date . "T" . "08:00";
        $event['end'] = $workShift->date . "T" . "20:00";
        break;
    }

    return $event;
  }

  public static function assignAvailable()
  {
    $nextMonday = Carbon::parse('monday next week');
    $nextSunday = Carbon::parse('sunday next week');

    $availableWorkshifts = static::getAvailableWorkShiftsBetween($nextMonday, $nextSunday);
    $workers = static::getWorkersInfo($nextMonday, $nextSunday);

    foreach ($availableWorkshifts as $workShift) {
      $workersNeedSort = false;

      foreach ($workers as $worker) {
        if ($workShift->workers_needed == $workShift->workers_assigned) {
          break;
        }

        if (
          $worker->preferences->first() &&
          $worker->workshifts_count >= $worker->preferences->first()->shifts_per_week
        ) {
          continue;
        }

        if (!$worker->workShifts->contains($workShift)) {
          $worker->workShifts()->attach($workShift);
          $workShift->workers_assigned += 1;
          $worker->workshifts_count += 1;
          $workersNeedSort = true;
        }
      }

      if ($workersNeedSort) {
        $workers = static::sortWorkers($workers);
      }
    }

    return response()->json(['success' => 'success'], 200);
  }

  private static function sortWorkers($workers)
  {
    return $workers->sortBy(function ($worker) {
      if ($worker->preferences->first()) {
        return $worker->preferences->first()->shifts_per_week - $worker->workshifts_count;
      }

      return $worker->workshifts_count;
    });
  }

  private static function getAvailableWorkShiftsBetween($startDate, $endDate)
  {
    return WorkShift::withCount('workers as workers_assigned')
      ->where([
        ['date', '>=',  $startDate],
        ['date', '<=', $endDate]
      ])
      ->get()
      ->reject(function ($workShift) {
        return $workShift->workers_assigned >= $workShift->workers_needed;
      });
  }

  private static function getWorkersInfo($startDate, $endDate)
  {
    $preferencesFilter = function ($q) use (&$startDate, &$endDate) {
      $q->where([
        ['start_date', '>=',  $startDate],
        ['end_date', '<=', $endDate],
        ['shifts_per_week', '>', 'worksifts_count']
      ]);
    };

    $workShiftsFilter = function ($query) use (&$startDate, &$endDate) {
      $query->where([
        ['date', '>=', $startDate],
        ['date', '<=', $endDate]
      ]);
    };

    $sortingCallback = function ($worker) {
      return $worker->preferences->first()->shifts_per_week - $worker->worksifts_count;
    };

    $workersWithPreferences = Worker::withCount('workshifts')
      ->whereHas('preferences', $preferencesFilter)
      ->with(['preferences' => $preferencesFilter])
      ->get()
      ->sortByDesc($sortingCallback);

    $workersWithoutPreferences = Worker::withCount(['workshifts' => $workShiftsFilter])
      ->whereDoesntHave('preferences')
      ->orderBy('workshifts_count')
      ->get();

    return $workersWithPreferences->merge($workersWithoutPreferences);
  }
}
