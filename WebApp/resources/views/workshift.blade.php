@extends('workshift_view')
@section('body')
<h1 id="header">Please select an employee</h1>
<select id="selectEmployee" onchange="LoadEmployees()">

    @foreach((array)$eployees as $emp)

    <option value={{$emp[1]}}>{{$emp[0]}}</option>

    @endforeach
</select>
@endsection

@section('scripts')
<script>
    document.getElementById("selectEmployee").selectedIndex = -1;

    function LoadEmployees() {

        let x = document.getElementById("selectEmployee").value;

        window.location.replace("/workshift_view/" + x);
    }

    function Load() {

    }
</script>
@endsection