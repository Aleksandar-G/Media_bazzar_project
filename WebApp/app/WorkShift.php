<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class WorkShift extends Model
{
    protected $fillable = [
        'shift', 'date', 'worker_id'
     ];

    public function worker()
    {
        return $this->belongsTo('App\Worker');
    }
}
