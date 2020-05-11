<?php

/** @var \Illuminate\Database\Eloquent\Factory $factory */

use App\User;
use Faker\Generator as Faker;
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
        'email_verified_at' => now(),
        'password' => '$2y$10$92IXUNpkjO0rOQ5byMi.Ye4oKoEa3Ro9llC/.og/at2.uheWG/igi', // password
        'phone' => '0881234567',
        'salary' => $faker->numberBetween(1000,10000),
        'role' => $faker->randomElement(['Manager', 'Administrator', 'Worker', 'Supervisor']),
        'birthday' => '1990-11-11',
        'remember_token' => Str::random(10),
        'updated_at' => '2020-05-11 17:59:45',
        'created_at' => '2020-05-11 17:59:45',
        'start_date' => '2020-07-01'
    ];
});
