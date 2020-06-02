<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

use App\Supervisor;
use App\Worker;

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

  public static function getEvents($id)
  {
    $workShifts = Worker::firstWhere('user_id', $id)->workShifts()->get()->all();

    $events = array();

    foreach ($workShifts as $workShift) {
      $event = static::transformToEvent($workShift);
      array_push($events, $event);
    }

    return (json_encode($events));
  }

  private static function GetManagedWorkers($role)
  {
    $workers = Worker::all();

    if($role == 'Supervisor') {
      $supervisor = Supervisor::where('user_id', (Auth::user()->id))->first();

      $workers = $workers->reject(function ($worker) use(&$supervisor) {
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

    $otherWorkers = $workShift->workers->map(function ($worker) {
      return $worker->user->name;
    });

    $event['title'] = "Shift for $$workShift->wage with $otherWorkers";

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
      default:
        $event['start'] = $workShift->date . "T" . "08:00";
        $event['end'] = $workShift->date . "T" . "20:00";
        break;
    }

    return $event;
  }
}
