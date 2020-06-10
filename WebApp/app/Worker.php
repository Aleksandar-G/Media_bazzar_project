<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Worker extends Model
{
    protected $fillable = [
        'user_id', 'department_id'
    ];

    public function user()
    {
        return $this->belongsTo('App\User');
    }

    public function department()
    {
        return $this->belongsTo('App\Department');
    }

    public function workShifts() 
    {
        return $this->belongsToMany('App\WorkShift', 'workers_work_shifts')->withTimestamps();
    }

    public function preferences() 
    {
        return $this->hasMany('App\WorkerPreference');
    }

    public function leaves() 
    {
        return $this->hasMany('App\Leave');
    }
}
