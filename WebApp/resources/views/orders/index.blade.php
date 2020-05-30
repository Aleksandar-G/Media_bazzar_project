@extends('layouts/app')

@section('head')
    <title>Laravel Bootstrap Datepicker</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.5.0/css/bootstrap-datepicker.css" rel="stylesheet">
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.5.0/js/bootstrap-datepicker.js"></script>
@endsection
  
@section('content')
    <div class="container" align="center">
        <h1 class="text-muted">Select Month</h1>
        <div class="input-group date col-xl-2">
            <input class="date form-control input-sm" type="text">
            <div class="input-group-addon">
                <span class="glyphicon glyphicon-th"></span>
            </div>
        </div>
    </div>
    
    <div class="container-products dark-bg">
        <table class="table text-white">
          <thead class="light-p-bg table-header">
            <tr class="d-flex">
                <th scope="col" class="col-1 no-border">ID</th>
                <th scope="col" class="col-3 no-border">Created by</th>
                <th scope="col" class="col-2 no-border">Total price</th>
                <th scope="col" class="col-4 no-border">Time of Order</th>
                <th scope="col" class="col-2 no-border"></th>
            </tr>
          </thead>
          <tbody>

            @foreach ($orders as $order)
                <tr class="d-flex">
                    <th scope="row" class="col-1">{{ $order->id }}</th>
                    <td class="col-3">{{ $order->user->name }}</td>
                    <td class="col-2">{{ $order->total_price }}</td>
                    <td class="col-4">{{ $order->created_at }}</td>
                    <td class="col-2"><a href='/orders/{{$order->id}}' class="btn btn-orange btn-block">Details</a></td>
                </tr>
            @endforeach
          </tbody>
        </table>
    </div>
    
    <script type="text/javascript">
        $('.date').datepicker({  
            minViewMode: "months",
            format: 'mm-yyyy'
         });  
    </script>      
@endsection