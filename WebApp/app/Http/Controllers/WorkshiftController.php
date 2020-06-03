<?php

namespace App\Http\Controllers;

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

    return view('workshift_view', ['id' => Auth::user()->id]);
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
    $userWorkShifts = Worker::firstWhere('user_id', $id)
      ->workShifts()
      ->withCount('workers as workers_assigned')
      ->get();

    $events = array();

    foreach ($userWorkShifts as $workShift) {
      $event = static::transformToEvent($workShift);
      array_push($events, $event);
    }

    $availavleWorkshifts = WorkShift::withCount('workers as workers_assigned')
      ->where('date', '>=',  Carbon::today())
      ->get()
      ->reject(function ($workShift) use (&$userWorkShifts) {
        return $workShift->workers_assigned + 1 >= $workShift->workers_assigned && $userWorkShifts->contains($workShift);
      });;

    foreach ($availavleWorkshifts as $workShift) {
      $event = static::transformToEvent($workShift);
      $event['classNames'] = ['available-shift'];
      $event['workshift_id'] = $workShift->id;
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
}
