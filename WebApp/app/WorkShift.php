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

    # TODO: Validate the number of workers
    // protected static function validateWorkers($model) {
    //     if ($model->workers_needed < $model->workers->count()) {
    //         throw new Exception("Shift is full");
    //     }
    // }
}
