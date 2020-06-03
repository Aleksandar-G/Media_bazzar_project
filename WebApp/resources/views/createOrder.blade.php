@extends('layouts.app')
@section('head')
<link rel="dns-prefetch" href="//fonts.gstatic.com">
<link href="https://fonts.googleapis.com/css?family=Nunito" rel="stylesheet">
<link href="{{ asset('css/app.css') }}" rel="stylesheet">
@endsection
@section('content')
<div class="container-fluid mt-3">
    <h2 class="text-center text-white mb-4">Place Order Here</h2>
    <div class="container-fluid">

        <div class="row ml-3">
            <div class="col-5 m-0 p-0">
                <input type="text" class="input-field" id="searchfield" name="quantity" placeholder="Type product name">
            </div>
            <div class="col-2"></div>
            <div class="col-5">
                <h3 class="text-white">Ordered Items:</h3>
            </div>
        </div>
        <br>
        <div class="row mt-1 ml-3">
            <table class="col-5 table text-white m-0 p-0">
                <thead class="light-p-bg table-header">
                    <tr class="d-flex">
                        <th scope="col" class="col-6 no-border">Product name</th>
                        <th scope="col" class="col-4 no-border">Quantity</th>
                        <th scope="col" class="col-2 no-border">&nbsp;</th>
                    </tr>
                </thead>
                <tbody>

                </tbody>
            </table>
            <div class="col-2"></div>
            <div id="cart" class="col-5 text-white">
                <h3>There are no ordered items yet</h3>
            </div>
        </div>
    </div>
    <script>
        $(document).ready(function () {
            let result
            let products = []

            let fillTable = (v) => {
                $("tbody").append(
                    `<tr product-id="${v.id}" class="d-flex">
                        <th scope="col" class="col-6 no-border">${v.name}</th>
                        <th scope="col" class="col-4 no-border">
                            <div class="qty">
                                <span class="minus bg-dark">-</span>
                                <input id=${v.id} quantity="${v.quantity}" type="number" class="count" name="quantity" value="${v.quantity <= 0 ? 0 : 1}">
                                <span class="plus bg-dark">+</span>
                            </div>
                        </th>
                        <th scope="col" class="col-2 no-border">
                            <button id="${v.id}" ${v.quantity <= 0 ? 'disabled' : ''} product-name="${v.name}" product-price="${v.selling_price}" class="add btn btn-orange">Add</button>
                        </th>
                    </tr>`
                )
            }
            let fillCart = (arr, sum) => {
                $("#cart").html("")
                $("#cart").append(`
                        <div class="row mb-3">
                            <div class="col-4">
                                <h4>Product Name</h4>
                            </div>
                            <div class="col-2">
                                <h4>Quantity</h4>
                            </div>
                            <div class="col-1">

                            </div>
                            <div class="col-3">
                                <h4>Price</h4>
                            </div>
                            <div class="col-2">
                            </div>
                        </div>`)
                arr.forEach( item => {
                    $("#cart").append(`
                        <div class="row mb-1 mt-1 p-0">
                            <div class="col-4">${item.name}</div>
                            <div class="col-2">${item.quantity}</div>
                            <div class="col-1"><h5>x</h5></div>
                            <div class="col-3">${item.price}</div>
                            <div class="col-2">
                                <button product-id="${item.id}" class="remove btn btn-sm btn-orange">Remove</button>
                            </div>
                            <hr class="rowhr">
                        </div>
                    `)
                })
                $("#cart").append(`
                        <div class="row mb-1 mt-1 p-0">
                            <hr class="summary-hr">
                            <div class="col-6 summary-h">TOTAL: ${sum.toFixed(2)} $</div>
                            <div class="col-6">
                                <button id="checkout" class="btn btn-orange">Checkout order</button>
                            </div>
                        </div>
                `)
            }

            $("tbody").html("<h2>Loading...</h2>")
            fillCart(products, 0)
            $.get('/products/show', function (data) {
                $("tbody").html("")
                result = JSON.parse(data)
                result.forEach(fillTable)
            })

            $("#searchfield").keyup(function (e) {
                $("tbody").html("<h2>Loading...</h2>")
                let input = e.target.value
                let filtered = result.filter(word => word.name.toLowerCase().includes(input
                    .toLowerCase()))
                console.log(filtered)
                $("tbody").html("")
                if (filtered.length == 0) {
                    $("tbody").append("<h3>No such item</h3>")
                }
                filtered.forEach(fillTable)

            })

            let id, input_element
            $(document).on('click', '.plus', function () {
                id = $(this).closest('tr').attr('product-id')
                input_element = $(`input#${id}`)
                if (parseInt(input_element.val()) >= parseInt(input_element.attr("quantity"))) {
                    input_element.val(parseInt(input_element.attr("quantity")))
                } else {
                    input_element.val(parseInt(input_element.val()) + 1)
                }
            })
            $(document).on('click', '.minus', function () {
                id = $(this).closest('tr').attr('product-id')
                input_element = $(`input#${id}`)

                if (parseInt(input_element.val()) <= 0) {
                    input_element.val(0)
                } else {
                    input_element.val(parseInt(input_element.val()) - 1)
                }
            })

            let total_price = 0

            $(document).on('click', 'button.add', function () {
                let id = $(this).attr('id')

                let product = {
                    id: parseInt(id),
                    quantity: parseInt($(`input#${id}`).val()),
                    name: $(this).attr('product-name'),
                    price: $(this).attr("product-price")
                }
                $(`input#${id}`).val(1)

                let temp = products.filter((item) => {
                    return item.id === product.id
                })

                let isValid = true;
                let addedQuantity = parseInt($(`input#${id}`).val());
                let maxQuantity = parseInt($(`input#${id}`).attr('quantity'));

                if(temp[0] && temp[0].quantity+addedQuantity>maxQuantity){
                    alert(`Available quantity of this product is ${$(`input#${id}`).attr('quantity')}`);
                    event.preventDefault();
                    isValid = false;
                    //console.log(temp[0].quantity+parseInt($(`input#${id}`).val()))
                }
                if(isValid){
                temp.length === 0 ? products.push(product) : products[products.indexOf(temp[0])].quantity += product.quantity
                //console.log(temp[0].quantity+parseInt($(`input#${id}`).val()));

                total_price = products.reduce((acc, value) => (acc + (value.price * value.quantity)), 0)

                fillCart(products, total_price)
                }

            })

            $(document).on('click', 'button.remove', function () {
                let searchedID = $(this).attr('product-id')
                let deleted_index = products.findIndex(item => item.id === parseInt(searchedID))

                products.splice(deleted_index, 1)
                total_price = products.reduce((acc, value) => (acc + (value.price * value.quantity)), 0)
                fillCart(products, total_price)
            })
            $(document).on('click', 'button#checkout', function () {
                if (products.length === 0) {
                    event.preventDefault()
                    alert("Empty order")
                } else {
                    let order = {
                        total_price:total_price.toFixed(2).toString(),
                        products:products,
                        _token: "{{ csrf_token() }}"
                    }

                    $.post('/orders',order)
                    .done(function(data){
                        window.location.replace(`/orders/${data.id}`)
                    })
                }
            })
        })

    </script>
</div>
@endsection
