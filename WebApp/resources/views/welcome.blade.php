@extends('layouts/app')
@section('content')
<div id="index" class="flex-center position-ref full-height">
    <!-- @if (Route::has('login'))
                <div class="top-right links">
                   
                </div>
            @endif -->

    <div class="content">
        <div class="display-3 m-b-md">
            Media Bazaar <br /> Web App<br />
        </div>
        @if (Route::has('login'))
        @auth
        <a class="w-100 btn btn-orange btn-lg " href="{{ url('/home') }}">Home</a>
        @else
        <a class=" w-100 btn btn-orange btn-lg " href="{{ route('login') }}">Login</a>
        @endauth
        @endif
    </div>
</div>
@endsection