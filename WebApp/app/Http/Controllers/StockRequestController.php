<?php

namespace App\Http\Controllers;

use App\Product;
use App\StockRequest;
use App\User;
use Illuminate\Support\Facades\Auth;
use Illuminate\Http\Request;
use App\Exceptions;
use Exception;
use Illuminate\Support\Facades\Session;

class StockRequestController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $products = Product::all();

        return view('stockRequest', ['products' => $products]);
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
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
                } else {
                    $productName = Product::find($productIds[$i])->name;
                    Session::flash('flash_message', "There is a stock request for $productName already");
                }
            } catch (Exception $ex) {

                StockRequest::create([
                    'user_id' => User::firstWhere('id', Auth::id())->id,
                    'product_id' => $productIds[$i],
                    'quantity' => $productQuantity[$i]
                ]);
            }
        }

        // return redirect("/Stoc")
        return redirect()->back();
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        //
    }
}
