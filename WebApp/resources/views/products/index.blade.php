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
        <th scope="col" class="col-3 no-border">ID</th>
        <th scope="col" class="col-4 no-border">Product Name</th>
        <th scope="col" class="col-3 no-border">Department</th>
        <th scope="col" class="col-2 no-border">Quantity</th>

      </tr>
    </thead>
    <tbody>
      <input type="text" class="input-field"  id="searchfield" onkeyup="search()" placeholder="Type product name">
      <button type="button" onclick="sortTableAlphabeticly()" class="btn btn-primary m-2"><i class="fa fa-sort">Sort by Product Name</i></button>
      <button type="button" onclick="sortTableDepartment()" class="btn btn-primary m-2"><i class="fa fa-sort">Sort by Department</i></button>
      @foreach ($products as $product)
      <tr class="d-flex">
        <th scope="row" id="{{ $product->id }}" class="col-3">{{ $product->id }}</th>
        <td class="col-4">{{ $product->name }}</td>
        <td class="col-3">{{ $product->department->name }}</td>
        <td class="col-2">{{ $product->quantity }}</td>
      </tr>
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

  <script>
    function sortTableAlphabeticly() {
      let table, rows, switching, i, x, y, shouldSwitch;
      table = document.getElementsByClassName("table text-white")[0];
      switching = true;

      while (switching) {

        switching = false;
        rows = table.rows;

        for (i = 1; i < (rows.length - 1); i++) {
          shouldSwitch = false;

          x = rows[i].getElementsByTagName("TD")[0];
          y = rows[i + 1].getElementsByTagName("TD")[0];

          if (x.innerHTML.toLowerCase() >= y.innerHTML.toLowerCase()) {
            shouldSwitch = true;
            break;
          }
        }
        if (shouldSwitch) {
          rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
          switching = true;
        }
      }
    }

    function sortTableDepartment() {
      let table, rows, switching, i, x, y, shouldSwitch;
      table = document.getElementsByClassName("table text-white")[0];
      switching = true;
      /*Make a loop that will continue until
      no switching has been done:*/

      while (switching) {
        //start by saying: no switching is done:
        switching = false;
        rows = table.rows;
        /*Loop through all table rows (except the
        first, which contains table headers):*/
        for (i = 1; i < (rows.length - 1); i++) {
          //start by saying there should be no switching:
          shouldSwitch = false;
          /*Get the two elements you want to compare,
          one from current row and one from the next:*/
          x = rows[i].getElementsByTagName("TD")[1];
          y = rows[i + 1].getElementsByTagName("TD")[1];

           // console.log(x.innerHTML);
            //console.log(y.innerHTML);
          //check if the two rows should switch place:
          if (x.innerHTML > y.innerHTML) {
            //if so, mark as a switch and break the loop:
            shouldSwitch = true;
            break;
          }
        }
        if (shouldSwitch) {
          /*If a switch has been marked, make the switch
          and mark that a switch has been done:*/
          rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
          switching = true;
        }
      }
    }
    function search() {
      let input, filter, table, tr, td, i, txtValue;
      input = document.getElementById("searchfield");
      filter = input.value.toUpperCase();
      table = document.getElementsByClassName("table text-white")[0];

      tr = table.getElementsByTagName("TR");
      for (i = 1; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("TD")[0];
        if (td) {
          txtValue = td.textContent || td.innerText;
          if (txtValue.toUpperCase().indexOf(filter) > -1) {
            tr[i].style.display = "";
          } else {
            tr[i].setAttribute('style', 'display:none !important');
          }
        }       
      }
    }
  </script>

</div>
@endsection