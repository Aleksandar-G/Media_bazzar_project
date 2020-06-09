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

Route::resource('/workshifts', 'WorkshiftController')->only(['index', 'show', 'store'])->middleware('auth');

Route::resource('products', 'ProductsController')->only([
    'index', 'show', 'update',
])->middleware('auth');

Route::resource('StockRequest','StockRequestController')->only(['index','store'])->middleware('auth');

Route::resource('orders', 'OrdersController')->middleware('auth');

Route::resource('preferences', 'WorkerPreferenceController')->middleware(['auth', 'isWorker']);

Route::get('downloadPDF/{id}','OrdersController@downloadPDF');
