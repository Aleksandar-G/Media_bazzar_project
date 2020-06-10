<?php

namespace App\Http\Controllers;

use App\Leave;
use Illuminate\Http\Request;

class LeaveController extends Controller
{
    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $leaveRequest = Leave::create($request->all());

        return response(json_encode($leaveRequest));
    }
}
