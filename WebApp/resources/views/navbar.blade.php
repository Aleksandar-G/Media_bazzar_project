<html>

<head>
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
  <style>

  </style>
</head>

<body>

  <div class="topnav" id="myTopnav">
    <a href="/workshift_view" class="active">Workshift View</a>
    <a href="/products">Products</a>
    <a href="/StockRequest">Stock Request</a>
    <a href="/orders/create">Create Order</a>
    <a href="/orders">Orders</a>
    <!-- <a href="/myprofile">My QR Code</a> -->

    <a id="logout" href="{{ route('logout') }}" onclick="logout()">Logout</a>
    <form id="logout-form" action="{{ route('logout') }}" method="POST" style="display: none;">
      @csrf
    </form>
    <a href="javascript:void(0);" class="icon" onclick="openNavbar()">
      <i class="fa fa-bars"></i>
    </a>
  </div>


  <script>
    function openNavbar() {
      var x = document.getElementById("myTopnav");
      if (x.className === "topnav") {
        x.className += " responsive";
      } else {
        x.className = "topnav";
      }
    }

    function logout() {
      event.preventDefault();
      document.getElementById('logout-form').submit();
    }
  </script>

</body>

</html>
