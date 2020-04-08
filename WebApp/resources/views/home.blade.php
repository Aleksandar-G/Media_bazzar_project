<?php
use App\Http\Controllers\CalendarController;
?>

<!DOCTYPE html>
<html lang='en'>
  <head>
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
          plugins: [  'dayGrid', 'timeGrid' ],
          defaultView: 'timeGridWeek',
          themeSystem: 'standard',
          events:'/workshifts', // use the `url` property

        });

        calendar.render();
      });

    </script>
  </head>
  <body>

    <div id='calendar' style = "margin:100px"></div>

  </body>
</html>