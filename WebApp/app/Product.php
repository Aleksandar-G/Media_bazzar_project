<?php

namespace App;

use Exception;
use Illuminate\Support\Facades\Auth;
use App\Worker;
use Illuminate\Database\Eloquent\Model;

class Product extends Model
{
    private const MIN_QUANTITY_AMOUNT = 5;
    protected $fillable = [
       'name', 'description', 'price', 'department_id'
    ];

    public function addQuantity(int $quantity) {
        $this->quantity += $quantity;
        $this->save();
    }

    public function decreaseQuantity(int $quantity) {
        if($this->quantity < $quantity) {
            throw new Exception("Not enough quantity");
        }

        error_log($quantity);
        $this->quantity -= $quantity;
        $this->save();

        if ($this->quantity < self::MIN_QUANTITY_AMOUNT) {
            StockRequest::create([
                'worker_id' => Worker::firstWhere('user_id', Auth::id())->id,
                'product_id' => $this->id,
                'quantity' => self::MIN_QUANTITY_AMOUNT
            ]);
        }
    }

    public function department()
    {
        return $this->belongsTo('App\Department');
    }
}
