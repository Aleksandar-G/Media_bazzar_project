<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class StockRequest extends Model
{
    protected $fillable = [
        'worker_id', 'product_id', 'quantity'
    ];

    public function complete()
    {
       $this->completed = true;
       $this->save();
    }

    public function worker() 
    {
        return $this->belongsTo('App\Worker');
    }

    public function product()
    {
        return $this->belongsTo('App\Product');
    }
}
