<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">

    <title>Order PDF</title>

    <style>
        @font-face {
          font-family: 'Helvetica';
          font-weight: normal;
          font-style: normal;
          font-variant: normal;
          src: url("font url");
        }
        body {
          font-family: Helvetica, sans-serif;
        }
        table {
            border: 1px solid black;
            width: 100%;
        }
        th, td {
            padding: 10px;
            border-bottom: 1px solid #ddd;
        }
        th {
            height: 30px;
        }

        h1, h4{
            text-align: center;
        }

        p{
            text-align: center;
            margin-top: 5px;
            margin-bottom: 10px;
        }
    </style>

  </head>
  <body>
    <h1>Order ID: {{$order->id}}</h1>
    <p><small>Created on {{$order->created_at}} by {{$order->user->name}}</small></p>
    <table>
        <thead>
            <tr class="d-flex">
                <th scope="col" class="col-2">Product ID</th>
                <th scope="col" class="col-4">Name</th>
                <th scope="col" class="col-2">Price</th>
                <th scope="col" class="col-2">Quantity</th>
                <th scope="col" class="col-2">Total</th>
            </tr>
        </thead>
        <tbody>
            @foreach($order->products as $product)
                    <tr class="d-flex">
                        <th scope="row" class="col-2">{{$product->id }}</th>
                        <th class="col-4">{{$product->name}}</th>
                        <th class="col-2">${{$product->selling_price}}</th>
                        <th class="col-2">{{$product->pivot->quantity}}</th>
                        <th class="col-2">${{$product->selling_price * $product->pivot->quantity}}</th>
                    </tr>
                @endforeach
        </tbody>
    </table>
    <h4>Total Price: ${{$order->total_price}}</h4>
  </body>
</html>