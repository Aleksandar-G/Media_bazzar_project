<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class WorkerPreference extends Model
{
    protected $fillable = [
        'worker_id', 'start_date', 'end_date', 'shifts_per_week'
    ];

    public function worker()
    {
        return $this->belongsTo('App\Worker');
    }
}
