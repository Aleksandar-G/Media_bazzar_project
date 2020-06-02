<!DOCTYPE html>
<html lang="en">
@extends('layouts/app')

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Workshifts Of Employees</title>
  <link href="/css/workshiftView.css" rel='stylesheet'>
  <meta charset='utf-8' />

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
          daysOfWeek: [1, 2, 3, 4, 5],
          startTime: '8:00',
          endTime: '20:00',
        },
        aspectRatio: 2.2,
        events: '/api/workshifts/{{$id}}',
        eventColor: "#2d132c",
        eventTextColor: "#ffffff",
        minTime: '7:00',
        maxTime: "21:00",
        height: 765,
        nowIndicator: true,
        eventClick(info) {
          console.log(info)
        }
      });

      calendar.render();
    });
  </script>

</head>

<body id="index">
  @section('content')
    @yield('body')
    <div id="calendar"></div>
    @yield('scripts')
  @endsection
</body>

</html>