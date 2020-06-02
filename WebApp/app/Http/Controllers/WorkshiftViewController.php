<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

use App\Supervisor;
use App\User;
use App\WorkShift;
use App\Worker;
use Illuminate\Support\Facades\Redirect;

class WorkshiftViewController extends Controller
{
  private static function FilterEmployees($wrk)
  {
    $NameIdWorker = null;
    $emp = User::where('id', $wrk->user_id)->first();
    $NameIdWorker = array();
    array_push($NameIdWorker, $emp->name, $emp->id);

    return $NameIdWorker;
  }

  public static function GetEmployees($role)
  {
    $loggedin = Auth::user();
    $employees = array();

    if ($role == "Supervisor") {
      $user = Supervisor::where('user_id', ($loggedin->id))->first();

      foreach (Worker::get() as $worker) {
        if ($user->department_id == $worker->department_id) {
          array_push($employees, WorkshiftViewController::FilterEmployees($worker));
        }
      }
    } else if ($role == "Manager" || $role == "Administrator") {
      foreach (Worker::get() as $w) {
        array_push($employees, WorkshiftViewController::FilterEmployees($w));
      }
    }

    return $employees;
  }

  public static function index()
  {
    //loads the employees from the model for the dropdown in the view
    $loggedin = Auth::user();
    $role = $loggedin->role;
    $employees = WorkshiftViewController::GetEmployees($role);

    if ($role == "Supervisor" || $role == "Manager" || $role == "Administrator") {
      return view('workshift', ['employees' => $employees, "id" => Worker::all()->first()->id]);
    }

    return view('workshift_view', ['id' => Auth::user()->id]);
  }

  public static function show($id)
  {
    //again load the employees from the model for the dropdown and send the wildcard to the view as well
    $loggedin = Auth::user();
    $role = $loggedin->role;
    if ($role == "Worker") {
      return redirect("/workshift_view");
    }

    $employees = WorkshiftViewController::GetEmployees($role);

    return view('workshift', ['employees' => $employees, 'id' => $id]);
  }

  public static function getEvents($id)
  {
    //Gets the workshifts from the models for the calendar

    $result = Worker::firstWhere('user_id', $id)->workShifts()->get()->all();

    $arr = array();

    foreach ($result as $value) {
      $row = array();
      $otherWorkers = $value->workers
        ->reject(function ($worker) use (&$id) {
          return $worker->user_id !== $id;
        })->map(function ($worker) {
          return $worker->user->name;
        });

      $row['title'] = "Shift for $$value->wage with $otherWorkers";

      $originalDate = $value->date;
      if ($value->shift == "Morning") {
        $row['start'] = $originalDate . "T" . "08:00:00";
        $row['end'] = $originalDate . "T" . "12:00:00";
      } else if ($value->shift == "Afternoon") {
        $row['start'] = $originalDate . "T" . "12:00";
        $row['end'] = $originalDate . "T" . "16:00";
      } else {
        $row['start'] = $originalDate . "T" . "16:00";
        $row['end'] = $originalDate . "T" . "20:00";
      }
      array_push($arr, $row);
    }

    return (json_encode($arr));
  }
}
