<?php

namespace App;

use Exception;
use Illuminate\Support\Facades\Auth;
use App\Worker;
use Illuminate\Database\Eloquent\Model;

class Product extends Model
{
    protected $fillable = [
        'name',
        'description',
        'buying_price',
        'selling_price',
        'department_id',
        'min_quantity'
    ];

    public function addQuantity(int $quantity)
    {
        $this->quantity += $quantity;
        $this->save();
    }

    public function decreaseQuantity(int $quantity)
    {
        if ($this->quantity < $quantity) {
            throw new Exception("Not enough quantity");
        }

        $this->quantity -= $quantity;
        $this->save();

        if ($this->quantity < $this->min_quantity) {
            try {
                StockRequest::where('product_id', $this->id)
                    ->where('completed', 0)
                    ->firstOrFail();
            } catch (Exception $ex) {
                StockRequest::create([
                    'user_id' => User::firstWhere('id', Auth::id())->id,
                    'product_id' => $this->id,
                    'quantity' => $this->min_quantity
                ]);
            }
        }
    }

    public function department()
    {
        return $this->belongsTo('App\Department');
    }
}
