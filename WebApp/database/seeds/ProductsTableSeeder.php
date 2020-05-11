<?php

use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;

class ProductsTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        DB::table('products')->insert([
            [
                'name' => 'Samsung Keyboard',
                'description' => 'loremipsumloremipsumloremipsumloremipsum',
                'price' => 666,
                'quantity' => 10,
                //'department_id' => 1,
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Apple Keyboard',
                'description' => 'loremipsumloremipsumloremipsumloremipsum',
                'price' => 777,
                'quantity' => 10,
                //'department_id' => 1,
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Fifa 20',
                'description' => 'loremipsumloremipsumloremipsumloremipsum',
                'price' => 120,
                'quantity' => 10,
                //'department_id' => 2,
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Mortal Kombat',
                'description' => 'loremipsumloremipsumloremipsumloremipsum',
                'price' => 99,
                'quantity' => 10,
                //'department_id' => 2,
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Samsung Tablet',
                'description' => 'loremipsumloremipsumloremipsumloremipsum',
                'price' => 666,
                'quantity' => 10,
                //'department_id' => 3,
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Apple Stove',
                'description' => 'loremipsumloremipsumloremipsumloremipsum',
                'price' => 1666,
                'quantity' => 0,
                //'department_id' => 4,
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Apple Washing machine',
                'description' => 'loremipsumloremipsumloremipsumloremipsum',
                'price' => 3666,
                'quantity' => 10,
                //'department_id' => 5,
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Samsung Galaxy S11',
                'description' => 'loremipsumloremipsumloremipsumloremipsum',
                'price' => 999,
                'quantity' => 10,
                //'department_id' => 6,
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Samsung TV',
                'description' => 'loremipsumloremipsumloremipsumloremipsum',
                'price' => 666,
                'quantity' => 10,
                //'department_id' => 7,
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Samsung Fridge',
                'description' => 'loremipsumloremipsumloremipsumloremipsum',
                'price' => 666,
                'quantity' => 10,
                //'department_id' => 8,
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Samsung Headphone',
                'description' => 'loremipsumloremipsumloremipsumloremipsum',
                'price' => 666,
                'quantity' => 10,
                //'department_id' => 9,
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Samsung Gadget',
                'description' => 'loremipsumloremipsumloremipsumloremipsum',
                'price' => 666,
                'quantity' => 10,
                //'department_id' => 1,
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ]

        ]);
    }
}
