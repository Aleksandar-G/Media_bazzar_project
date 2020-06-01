@extends('layouts/app')
@section("content")


@if(Session::has('flash_message'))
<div class="alert alert-warning">
    {{ Session::get('flash_message') }}
</div>
@endif
<script>
    $(document).ready(function() {

        $(".alert").fadeTo(3000, 500).slideUp(500, function() {
            $(".alert").slideUp(500);
        });

        /*const ptext = $('#slides p').toArray().map(p => p.innerHTML);*/

        $(".add-row").click(function() {

            let ProducctElements = document.getElementsByClassName("productname");
            let products = [];
            for (let i = 0; i < ProducctElements.length; i++) {
                products.push(ProducctElements[i].innerHTML);
            }
            let name = $("#selectProduct option:selected").text();
            let productid = $("#selectProduct option:selected").val();
            if (products.includes(name)) {
                alert("item already added");
                return;
            }

            let quantity = $("#quantity").val();
            if (quantity <= 0) {
                alert("Please input a valid quantity");
            }
            let markup = `<tr class='d-flex'>
                <th scope='row' class='col-1'>
                <input type='checkbox' name='record'>
                </th><td class='col-8 productname'> ${name} </td>
                <td class='col-3'> ${quantity} </td>
                 <input type='hidden' name='productId[]'  value= '${productid}' >
                 </input><input type='hidden' name='quantity[]'  value= '${quantity}'></input> </tr>`;
            $("table tbody").append(markup);

            document.getElementById("quantity").value = 0;
        });
        // Find and remove selected table rows
        $(".delete-row").click(function() {
            $("table tbody").find('input[name="record"]').each(function() {
                if ($(this).is(":checked")) {
                    $(this).parents("tr").remove();
                }
            });
        });
    });
</script>
<div class="addMenu">

    <select id="selectProduct">

        @foreach($products as $product)

        <option value="{{ $product->id }}">{{ $product->name }}</option>

        @endforeach

    </select>
    <input type="text" id="quantity" placeholder="quantity">
    <input type="button" class="add-row btn btn-primary" value="Add Row">
</div>
<form action="/StockRequest" method="POST">
    @csrf
    <div class="container-StockRequest dark-bg">
        <table class="table text-white">
            <thead class="light-p-bg table-header">
                <tr class="d-flex">
                    <th scope="col" class="col-1 no-border"></th>
                    <th scope="col" class="col-8 no-border">Product Name</th>
                    <th scope="col" class="col-4 no-border">Quantity</th>
                </tr>
            </thead>
            <tbody>
                <tr class='d-flex'>
                    <th scope='row' class='col-1'>
                        <input type='checkbox' name='record'>
                    </th>
                    <td class='col-8 productname'> tv </td>
                    <td class='col-3'> 10 </td>
                    <input type='hidden' name='productId[]' value='1'>
                    </input><input type='hidden' name='quantity[]' value='10'></input>
                </tr>
            </tbody>
        </table>
    </div>
    <div class="bottomMenu">
        <button type="button" class="delete-row btn btn-danger">Delete Row</button>
        <input type="submit" class="create btn btn-primary"></input>
    </div>
</form>

@endsection