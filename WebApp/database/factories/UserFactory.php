<?php

/** @var \Illuminate\Database\Eloquent\Factory $factory */

use App\User;
use Faker\Generator as Faker;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Str;

/*
|--------------------------------------------------------------------------
| Model Factories
|--------------------------------------------------------------------------
|
| This directory should contain each of the model factory definitions for
| your application. Factories provide a convenient way to generate new
| model instances for testing / seeding your application's database.
|
*/

$factory->define(User::class, function (Faker $faker) {
    return [
        'name' => $faker->name,
        'email' => $faker->unique()->safeEmail,
        'password' => Hash::make('12345678'),
        'phone' => $faker->phoneNumber,
        'salary' => $faker->numberBetween(1000,10000),
        'role' => $faker->randomElement(['Manager', 'Administrator', 'Worker', 'Supervisor']),
        'birthday' =>  $faker->dateTime($max = 'now', $timezone = null),
        'updated_at' =>  now(),
        'created_at' =>  now(),
        'start_date' =>  $faker->dateTime($min = 'now', $timezone = null),
    ];
});
