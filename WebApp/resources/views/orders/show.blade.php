@extends('layouts/app')

@section('content')
    <div class="mt-5 text-white text-center">
        <h1 class="mt-3">Order ID: {{$order->id}}</h1>
        <small>Created on {{$order->created_at}} by {{$order->user->name}}</small>

        <div class="container-products dark-bg">
            <table class='table text-white'>
                <thead class="light-p-bg table-header">
                    <tr class="d-flex">
                        <th scope="col" class="col-2 no-border">Product ID</th>
                        <th scope="col" class="col-4 no-border">Name</th>
                        <th scope="col" class="col-2 no-border">Price</th>
                        <th scope="col" class="col-2 no-border">Quantity</th>
                        <th scope="col" class="col-2 no-border">Total</th>
                    </tr>
                  </thead>
                  <tbody>
                    @foreach($order->products as $product)
                        <tr class="d-flex">
                            <th scope="row" class="col-2">{{ $product->id }}</th>
                            <th class="col-4">{{$product->name}}</th>
                            <th class="col-2">${{$product->selling_price}}</th>
                            <th class="col-2">{{$product->pivot->quantity}}</th>
                            <th class="col-2">${{$product->selling_price * $product->pivot->quantity}}</th>
                        </tr>
                    @endforeach
                  </tbody>
            </table>
            <h4 class="mt-5">Total Price: ${{$order->total_price}}</h4>
            <a class='mt-4 pt-2 pb-2 btn btn-orange' href="{{action('OrdersController@downloadPDF', $order->id)}}">Generate PDF</a>
        </div>
    </div>
@endsection