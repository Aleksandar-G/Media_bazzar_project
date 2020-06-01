@extends('layouts/app')

@section('head')
<link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/css/bootstrap-datepicker.css" rel="stylesheet">
<script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/js/bootstrap-datepicker.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.26.0/moment.min.js" integrity="sha256-5oApc/wMda1ntIEK4qoWJ4YItnV4fBHMwywunj8gPqc=" crossorigin="anonymous"></script>
@endsection

@section('content')
<div class="preferences-page d-flex align-items-center">
    <div class="container dark-bg">
        <h1 class="text-center text-white">My Work Preferences</h1>
        <br>
        <div class="row justify-content-md-center">
            <div class="col-6 form-group">
                <label for="weeklyDatePicker" class="text-white d-block text-center"><h3>Select week:</h3></label>
                <div class="input-group">
                    <input autocomplete="off" type='text' id='weeklyDatePicker' placeholder="Select Week" class="form-control text-center input-field" />
                </div>
            </div>
        </div>

        <br>
        
        <div class="row justify-content-md-center">
            <div class="col-6 form-group">
                <label for="shifts" class="text-white d-block text-center"><h3>Preferred number of shifts for that week:</h3></label>
                <div class="input-group">
                    <input id="shifts" class="form-control text-center input-field" type="number" placeholder="Shifts per week" value="{{ $shifts ?? '' }}">
                </div>
            </div>
        </div>

        <br>

        <div class="row justify-content-md-center">
            <div class="col-6 form-group">
                <div class="input-group">
                    <button id="save-btn" type="button" class="btn btn-orange btn-block">Save</button>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    let queryParams = new URLSearchParams(window.location.search)
    let startDate = queryParams.get('startDate')
    let endDate = queryParams.get('endDate')

    if (startDate && endDate) {
        $("#weeklyDatePicker").val(startDate + " - " + endDate)
    }

    $("#weeklyDatePicker").datepicker({
        format: 'yyyy-mm-dd',
        weekStart: 1,
        startDate: moment().add(7, 'days').format('YYYY-MM-DD')
    });

    $('#weeklyDatePicker').on('changeDate', function(e) {
        let value = $("#weeklyDatePicker").val()
        startDate = moment(value, "YYYY-MM-DD").day(1).format("YYYY-MM-DD")
        endDate = moment(value, "YYYY-MM-DD").day(7).format("YYYY-MM-DD")
        $("#weeklyDatePicker").val(startDate + " - " + endDate)

        $('.datepicker-dropdown').hide()

        window.location.replace(`/preferences?startDate=${startDate}&endDate=${endDate}`)

    });

    // $('#view-btn').click(() => {
    //     window.location.replace(`/preferences?startDate=${startDate}&endDate=${endDate}`)
    // })

    $('#save-btn').click(() => {
        $.post('/preferences', {
            start_date: startDate,
            end_date: endDate,
            shifts_per_week: $('#shifts').val(),
            "_token": "{{ csrf_token() }}",
        }).then(() => {
            window.location.replace(`/preferences?startDate=${startDate}&endDate=${endDate}`)
        })
    })
</script>
@endsection