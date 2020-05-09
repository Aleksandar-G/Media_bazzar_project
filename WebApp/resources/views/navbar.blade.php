<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<style>


</style>
</head>
<body>

<div class="topnav" id="myTopnav">
  <a href="/home" class="active">Home</a>
  <a href="/products">Products</a>
  <a href="/myprofile">My QR Code</a>
  
  <a id="logout" href="{{ route('logout') }}"
  onclick="event.preventDefault();
  document.getElementById('logout-form').submit();"
  >Logout</a>
  <form id="logout-form" action="{{ route('logout') }}" method="POST" style="display: none;">
   @csrf
   </form>
  <a href="javascript:void(0);" class="icon" onclick="myFunction()">
    <i class="fa fa-bars"></i>
  </a>
</div>


<script>
function myFunction() {
  var x = document.getElementById("myTopnav");
  if (x.className === "topnav") {
    x.className += " responsive";
  } else {
    x.className = "topnav";
  }
}
</script>

</body>
</html>
