<?php

/** @var \Illuminate\Database\Eloquent\Factory $factory */

use App\Product;
use App\Department;
use Faker\Generator as Faker;

$factory->define(Product::class, function (Faker $faker) {
    $department = Department::orderByRaw("RAND()")->first();

    return [
        'name' => $faker->text($maxNbChars = 20),
        'description' => $faker->text($maxNbChars = 200),
        'price' => $faker->numberBetween(50,5000),
        'quantity' => 10,
        'department_id' => $department->id,
        'created_at' => $faker->dateTime($max = 'now', $timezone = null),
        'updated_at' =>  $faker->dateTime($max = 'now', $timezone = null),
    ];
});
