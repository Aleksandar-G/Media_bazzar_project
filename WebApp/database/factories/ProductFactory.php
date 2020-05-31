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
        'buying_price' => $faker->numberBetween(50,100),
        'selling_price' => $faker->numberBetween(101,150),
        'quantity' => 10,
        'min_quantity' => $faker->numberBetween(1, 10),
        'department_id' => $department->id,
        'created_at' => now(),
        'updated_at' =>  now()
    ];
});
