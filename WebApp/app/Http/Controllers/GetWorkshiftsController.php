<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

use App\User;
use App\Worker;
use App\WorkShift;

class GetWorkshiftsController extends Controller
{
    public static function index($name)
    {

      $workerId = 0;
      foreach(User::all() as $u)
      {
        if($u->name == $name)
        {
          $WorkerId = $u->id; 
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
      echo "sadasd";
    }
    
}
