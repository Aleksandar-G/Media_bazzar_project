<?php

namespace App\Http\Controllers\API;

use Illuminate\Http\Request;
use App\Http\Controllers\Controller;
use App\User;
use Illuminate\Auth\Events\PasswordReset;
use Illuminate\Support\Facades\Validator;
use Illuminate\Support\Facades\Hash;
use App\Notifications\MailSetPasswordNotification;


class UserController extends Controller
{
    public function register(Request $request)
    {
        $validator = Validator::make($request->all(), [
            'name' => 'required',
            'email' => 'required|email',
            'password' => 'required',
            'phone' => 'required',
            'salary' => 'required',
            'birthday' => 'required',
            'role' => 'required'
        ]);

        if ($validator->fails()) {
            return response()->json(['error' => $validator->errors()], 401);
        }

        $input = $request->all();
        $password = $input['password'];
        $input['password'] = Hash::make($input['password']);
        $user = User::create($input);
        $token = app('auth.password.broker')->createToken($user);

        $user->notify(new MailSetPasswordNotification($token, $user->email, $password));

        return response()->json(['success' => $user], 201);
    }
}
