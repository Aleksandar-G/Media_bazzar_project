<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Product;
use Exception;
use Illuminate\Support\Facades\Session;
class OrderController extends Controller
{
    //
    public function index(){
        $products = Product::all();
        return view('createOrder', ['products' => $products]);
    }
}
