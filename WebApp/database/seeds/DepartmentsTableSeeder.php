<?php

use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;

class DepartmentsTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        DB::table('departments')->insert([
            [
                'name' => 'Keyboards',
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Video games',
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Tablets',
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Cooking equipment',
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Washing Machines',
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Phones',
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'TVs',
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Fridges',
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Headphones',
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

            [
                'name' => 'Gadgets',
                'created_at' => '2020-05-11 15:30:20',
                'updated_at' => '2020-05-11 15:30:20',
            ],

        ]);
    }
}
