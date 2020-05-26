@extends('layouts/app')
@section("content")

<body>
    <script>
        $(document).ready(function() {
            $(".add-row").click(function() {
                let name = $("#selectProduct option:selected").text();
                let quantity = $("#quantity").val();
                //var email = $("#email").val();
                //var markup = "<tr class='d-flex'><td><input type='checkbox' name='record'></td><td>" + name + "</td><td>" + email + "</td></tr>";
                let markup = "<tr class='d-flex'><th scope='row' class='col-1'><input type='checkbox' name='record'></th><td class='col-8'>" + name + "</td><td class='col-3'>" + quantity + "</td> </tr>";
                $("table tbody").append(markup);
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

            <option>{{ $product->name }}</option>

            @endforeach

        </select>
        <input type="text" id="quantity" placeholder="quantity">
        <input type="button" class="add-row btn btn-primary" value="Add Row">
    </div>
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

            </tbody>
        </table>
    </div>
    <button type="button" class="delete-row btn btn-danger">Delete Row</button>
</body>
@endsection