<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class WorkShift extends Model
{
    protected $fillable = [
        'shift', 'date', 'wage', 'workers_needed'
    ];

    public function workers()
    {
        return $this->belongsToMany('App\Worker', 'workers_work_shifts')->withTimestamps();
    }
}
