@extends('layouts/app')

@section('content')
    <div class="mt-5 text-white text-center">
        <h1 class="mt-3">Order ID: {{$order->id}}</h1>
        <div>
            {{$order->price}}
        </div>
        <hr class='text-primary'>
        <small>Order created on {{$order->created_at}} by {{$order->user->name}}</small>
        <hr>
    </div>
@endsection