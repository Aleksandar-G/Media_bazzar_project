@extends('workshift_view')
@section('body')
<h1 id="header">Please select an employee</h1>
<select id="selectEmployee" onchange="LoadWorkshifts()">

    @foreach($workers as $worker)
        <option value="{{$worker['id']}}">{{$worker['name']}}</option>
    @endforeach
</select>
@endsection

@section('scripts')
<script>
    document.getElementById("selectEmployee").value = {{ $id }};

    function LoadWorkshifts() {
        let x = document.getElementById("selectEmployee").value;
        window.location.replace("/workshifts/" + x);
    }
</script>
@endsection