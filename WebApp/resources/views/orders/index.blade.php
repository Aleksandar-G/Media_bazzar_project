@extends('layouts/app')

@section('head')
    <title>Laravel Bootstrap Datepicker</title>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/css/bootstrap-datepicker.css" rel="stylesheet">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/js/bootstrap-datepicker.js"></script>      
    
@endsection
  
@section('content')
    <div class="container" align="center">
        <h1 class="text-white">Select Month</h1>
        <div class="input-group date col-4">
            <input autocomplete="off" id="datepicker" class="date text-center form-control input-md" type="text">
            <div class="input-group-addon"></div>
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
                    <!-- if($order->created_at->format('m-Y') == '05-2020') -->
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
            format: 'mm-yyyy',
            container: '.input-group.date',
         })
         $('#datepicker').on('changeDate', function(e) {    
            window.location.replace(`/orders?date=${e.format('yyyy-mm')}`);
            })
    </script> 
@endsection