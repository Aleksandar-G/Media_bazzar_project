<?php

namespace App\Http\Controllers;

use App\Product;
use App\StockRequest;
use App\User;
use Illuminate\Support\Facades\Auth;
use Illuminate\Http\Request;
use App\Exceptions;
use Exception;

class StockRequestContoller extends Controller
{
    public static function index()
    {
        $products = Product::all();

        return view('stockRequest', ['products' => $products]);
    }

    public static function store()
    {
        $productIds = request('productId');
        $productQuantity = request('quantity');

        for ($i = 0; $i < count($productIds); $i++) {
            try {
                $sr = StockRequest::where('product_id', $productIds[$i])
                    ->where('completed', 0)
                    ->firstOrFail();

                if ($sr->quantity < $productQuantity[$i]) {

                    StockRequest::where('id', $sr->id)
                        ->update(['quantity' => $productQuantity[$i]]);
                }
            } catch (Exception $ex) {

                StockRequest::create([
                    'user_id' => User::firstWhere('id', Auth::id())->id,
                    'product_id' => $productIds[$i],
                    'quantity' => $productQuantity[$i]
                ]);
            }
        }
    }
}
