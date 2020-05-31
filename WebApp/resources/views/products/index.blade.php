@extends('layouts.app')

@section('content')
@if(Session::has('flash_message'))
<div class="alert alert-success">
  {{ Session::get('flash_message') }}
</div>
@endif
<div class="container-products dark-bg">
  <table class="table text-white">
    <thead class="light-p-bg table-header">
      <tr class="d-flex">
        <th scope="col" class="col-1 no-border">ID</th>
        <th scope="col" class="col-4 no-border">Product Name</th>
        <th scope="col" class="col-3 no-border">Department</th>
        <th scope="col" class="col-2 no-border">Quantity</th>
        <th scope="col" class="col-2 no-border"></th>
      </tr>
    </thead>
    <tbody>
      @foreach ($products as $product)
      <tr class="d-flex">
        <th scope="row" id="{{ $product->id }}" class="col-1">{{ $product->id }}</th>
        <td class="col-4">{{ $product->name }}</td>
        <td class="col-3">{{ $product->department->name }}</td>
        <td class="col-2">{{ $product->quantity }}</td>
        <td class="col-2">
          <button class="btn btn-orange btn-block" data-toggle="modal" data-target="#buyProductModal-{{{$product->id}}}" {{ $product->quantity > 0 ? '' : 'disabled' }}>
            Decrease Amount
          </button>
        </td>
      </tr>

      <div class="modal fade" id="buyProductModal-{{{$product->id}}}" tabindex="-1" role="dialog" aria-labelledby="buyProductModalTitle" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
          <div class="modal-content">
            <div class="modal-header">
              <h5 class="modal-title" id="title">Decrease {{ $product->name }} amount</h5>
              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true">&times;</span>
              </button>
            </div>
            <div class="modal-body text-center">
              <form action="/products/{{$product->id}}" method="POST">
                @csrf
                @method('PUT')

                <h4>Decrease {{ $product->name }} by: </h4>
                <input type="hidden" name="product" value="{{ $product->id }}">
                <div class="qty">
                  <span class="minus bg-dark">-</span>
                  <input type="number" class="count" id="product-{{$product->id}}-quantity" name="quantity" value="1" min="0" max="{{{ $product->quantity }}}">
                  <span class="plus bg-dark">+</span>
                </div>
                <br>
                <button type="submit" class="btn btn-orange">Decrease</button>
              </form>
            </div>
          </div>
        </div>
      </div>

      <script type="text/javascript">
        let quantity = {
          {
            $product - > quantity
          }
        };

        $(document).ready(function() {
          $("#product-{{$product->id}}-quantity").prop('readonly', true);
          $(document).on('click', '.plus', function() {
            $("#product-{{$product->id}}-quantity").val(parseInt($("#product-{{$product->id}}-quantity").val()) + 1);
            if ($("#product-{{$product->id}}-quantity").val() >= quantity) {
              $("#product-{{$product->id}}-quantity").val(quantity);
            }
          });
          $(document).on('click', '.minus', function() {
            $("#product-{{$product->id}}-quantity").val(parseInt($("#product-{{$product->id}}-quantity").val()) - 1);

            if ($("#product-{{$product->id}}-quantity").val() <= 0) {
              $("#product-{{$product->id}}-quantity").val(1);
            }
          });
        });
      </script>
      @endforeach
    </tbody>
  </table>

</div>
@endsection