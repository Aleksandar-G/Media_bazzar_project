const mix = require('laravel-mix');

/*
 |--------------------------------------------------------------------------
 | Mix Asset Management
 |--------------------------------------------------------------------------
 |
 | Mix provides a clean, fluent API for defining some Webpack build steps
 | for your Laravel application. By default, we are compiling the Sass
 | file for the application as well as bundling up all the JS files.
 |
 */

mix.js('resources/js/app.js', 'public/js')
    .sass('resources/sass/app.scss', 'public/css');

mix.copy('node_modules/@fullcalendar/core/main.js', 'public/fullcalendar/core/main.js')
mix.copy('node_modules/@fullcalendar/core/main.css', 'public/fullcalendar/core/main.css')
mix.copy('node_modules/@fullcalendar/daygrid/main.js', 'public/fullcalendar/daygrid/main.js')
mix.copy('node_modules/@fullcalendar/daygrid/main.css', 'public/fullcalendar/daygrid/main.css')
mix.copy('node_modules/@fullcalendar/timegrid/main.js', 'public/fullcalendar/timegrid/main.js')
mix.copy('node_modules/@fullcalendar/timegrid/main.css', 'public/fullcalendar/timegrid/main.css')