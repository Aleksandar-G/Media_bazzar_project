<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Leave extends Model
{
    protected $fillable = [
        'worker_id',
        'from',
        'to',
        'description'
    ];

    public function approve()
    {
        $this->approved = true;
        $this->pending = false;
        $this->save();
    }

    public function decline()
    {
        $this->approved = false;
        $this->pending = false;
        $this->save();
    }

    public function worker() {
        return $this->belongsTo('App\Worker');
    }
}

