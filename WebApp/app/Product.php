<?php

namespace App;

use Exception;
use Illuminate\Database\Eloquent\Model;

class Product extends Model
{
    protected $fillable = [
       'name', 'description', 'price', 'department_id'
    ];

    public function addQuantity(int $quantity) {
        return $this->quantity += $quantity;
    }

    public function decreaseQuantity(int $quantity) {
        if($this->quantity < $quantity) {
            throw new Exception("Not enough quantity");
        }

        return $this->quantity -= $quantity;
    }

    public function department()
    {
        return $this->belongsTo('App\Department');
    }
}
