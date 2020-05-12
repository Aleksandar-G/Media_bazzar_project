<?php

use App\Department;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\DB;

class UsersTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        factory(App\User::class, 25)->create()->each(function ($user) {
            if($user->role == "Manager")
            {
                DB::table('managers')->insert([
                    'user_id' => $user->id,
                    'created_at' => $user->created_at,
                    'updated_at' => $user->updated_at
                ]);
            }
            else if($user->role == "Administrator")
            {
                DB::table('administrators')->insert([
                    'user_id' => $user->id,
                    'created_at' => $user->created_at,
                    'updated_at' => $user->updated_at
                ]);
            }
            else if($user->role == "Supervisor")
            {
                $department = Department::orderByRaw("RAND()")->first();

                DB::table('supervisors')->insert([
                    'user_id' => $user->id,
                    'department_id' => $department->id,
                    'created_at' => $user->created_at,
                    'updated_at' => $user->updated_at
                ]);
            }
            else
            {
                $department = Department::orderByRaw("RAND()")->first();

                DB::table('workers')->insert([
                    'user_id' => $user->id,
                    'department_id' => $department->id,
                    'created_at' => $user->created_at,
                    'updated_at' => $user->updated_at
                ]);
            }
        });
    }
}
