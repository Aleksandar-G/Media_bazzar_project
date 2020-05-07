<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

use App\Supervisor;
use App\User;
use App\WorkShift;
use App\Worker;


class WorkshiftViewController extends Controller
{
  public static function index()
  {
    //loads the employees from the model for the combox in the view
    $loggedin = Auth::user();
    $role = $loggedin->role;
    $employees = array();
    if ($role == "Supervisor") {
      $user = Supervisor::where('user_id', ($loggedin->id))->first();

      foreach (Worker::get() as $worker) {
        if ($user->department_id == $worker->department_id) {
          $emp = User::where('id', $worker->user_id)->first();

          array_push($employees, $emp->name);
        }
      }
      $emp = $emp->name;
    }

    if ($role == "Manager" || $role == "Administrator") {
      foreach (Worker::get() as $worker) {
        $emp = User::where('id', $worker->user_id)->first();
        array_push($employees, $emp->name);
      }
    }

    return view('workshift_view', ['eployees' => $employees]);
  }

  public static function show($name)
  {
    /*$workerId = 0;
    foreach (User::all() as $u) {
      if ($u->name == $name) {
        $workerId = $u->id;
        break;
      }
    }
    $worker = Worker::where('user_id', $workerId)->first();

    $result = Workshift::where('worker_id', $worker->id)->get();

    $arr = array();

    foreach ($result as $value) {
      $row = array();
      $row['title'] = "work";
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
    }*/
    //again load the employees from the model for the combox and send the wildcard to the view as well
    $loggedin = Auth::user();
    $role = $loggedin->role;
    $employees = array();
    if ($role == "Supervisor") {
      $user = Supervisor::where('user_id', ($loggedin->id))->first();

      foreach (Worker::get() as $worker) {
        if ($user->department_id == $worker->department_id) {
          $emp = User::where('id', $worker->user_id)->first();

          array_push($employees, $emp->name);
        }
      }
      $emp = $emp->name;
    }

    if ($role == "Manager" || $role == "Administrator") {
      foreach (Worker::get() as $worker) {
        $emp = User::where('id', $worker->user_id)->first();
        array_push($employees, $emp->name);
      }
    }

    return view('workshift', ['eployees' => $employees, 'name' => $name]);
  }

  public static function getEvents($name)
  {
    //Gets the workshifts from the models for the calendar
    $workerId = 0;
    foreach (User::all() as $u) {
      if ($u->name == $name) {
        $workerId = $u->id;
        break;
      }
    }
    $worker = Worker::where('user_id', $workerId)->first();

    $result = Workshift::where('worker_id', $worker->id)->get();


    $arr = array();

    foreach ($result as $value) {
      $row = array();
      $row['title'] = "work";
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
    echo (json_encode($arr));
  }
}
