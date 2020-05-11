@extends('layouts/app')
@section('head')
<link href="{{ URL::asset('fullcalendar/core/main.css') }}" rel='stylesheet' />
  <link href="{{ URL::asset('fullcalendar/daygrid/main.css') }}" rel='stylesheet' />
  <link href="{{ URL::asset('fullcalendar/timegrid/main.css') }}" rel='stylesheet' />
  <link href='https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css' rel='stylesheet' />


  <script src="{{ URL::asset('fullcalendar/core/main.js') }}"></script>
  <script src="{{ URL::asset('fullcalendar/daygrid/main.js') }}"></script>
  <script src="{{ URL::asset('fullcalendar/timegrid/main.js') }}"></script>

  <script>
    document.addEventListener('DOMContentLoaded', function() {
      var calendarEl = document.getElementById('calendar');

      var calendar = new FullCalendar.Calendar(calendarEl, {
        plugins: ['dayGrid', 'timeGrid'],
        defaultView: 'timeGridWeek',
        themeSystem: 'standard',
        businessHours: {
          daysOfWeek: [ 1, 2, 3, 4,5 ],
          startTime: '8:00',
          endTime: '20:00', 
          },
        events: '/workshifts', // use the `url` property
      });

      calendar.render();
    });
  </script>
   
@endsection

@section('content')

<div id='calendar' style="margin:100px"></div>
@endsection