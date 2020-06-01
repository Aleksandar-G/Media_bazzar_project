<?php

namespace App\Http\Controllers;

use App\Worker;
use Facade\FlareClient\Http\Response;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class WorkerPreferenceController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index(Request $request)
    {
        // Number of shifts for the selected week
        $preference = Worker::where('user_id', Auth::user()->id)
            ->with(['preferences' => function ($query) use (&$request) {
                $query->where([
                    ['start_date', '=', $request->query('startDate')],
                    ['end_date', '=', $request->query('endDate')]
                ]);
            }])
            ->first()
            ->preferences
            ->first();

            if(!is_null($preference)) {
                return view('preferences', ['shifts' => $preference->shifts_per_week]);
            }

            return view('preferences');
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $worker = Worker::where('user_id', Auth::user()->id)->first();
        $worker->preferences()->updateOrCreate(
            ['start_date' => $request->input('start_date'), 'end_date' => $request->input('end_date')],
            ['shifts_per_week' => $request->input('shifts_per_week')]
        );

        return response()->json(['success' => 'success'], 200);
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        //
    }
}
