<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Department extends Model
{
    protected $fillable = [
        'name'
    ];

    public function workers()
    {
        return $this->hasMany('App\Worker');
    }

    public function products()
    {
        return $this->hasMany('App\Product');
    }

    public function supervisor()
    {
        return $this->hasOne('App\Supervisor');
    }

}
