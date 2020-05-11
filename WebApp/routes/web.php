<?php

use Illuminate\Support\Facades\Route;
use Illuminate\Support\Facades\Auth;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});

Auth::routes();

/*Route::get('/home', function () {
    return view('home');
})->middleware('auth');*/

Route::get('/workshifts', 'CalendarController@index');

//Route::get('/logout', '\App\Http\Controllers\Auth\LoginController@logout');

Route::resource('products', 'ProductsController')->only([
    'index', 'show', 'update',
])->middleware('auth');

Route::get('/workshift_view', 'WorkshiftViewController@index')->middleware('auth');

Route::get('/workshift_view/{id}', 'WorkshiftViewController@show')->middleware('auth');

Route::get('/workshifts/{id}', 'WorkshiftViewController@getEvents')->middleware('auth');
