<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Workshifts Of Employees</title>
    @yield('head')

</head>

<body>
    <h1>Plaese select an employee</h1>
    <select id="selectEmployee" onchange="LoadEmployees()">

        @foreach((array)$eployees as $emp)

        <option value={{$emp}}>{{$emp}}</option>

        @endforeach
    </select>
    @yield('calendar')

    <script>
        function LoadEmployees() {

            let x = document.getElementById("selectEmployee").value;

            window.location.replace("/workshift_view/" + x);
        }
        window.addEventListener('load',(event) =>{
            document.getElementById("selectEmployee").selectedIndex = -1;
        })
        function Load(){

        }
    </script>
</body>

</html>