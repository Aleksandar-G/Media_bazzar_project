<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

use App\WorkShift;
use App\Worker;


class CalendarController extends Controller
{
    public static function index()
    {
        $user = Auth::user();
        $worker = Worker::where('user_id', $user->id)->first();
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
