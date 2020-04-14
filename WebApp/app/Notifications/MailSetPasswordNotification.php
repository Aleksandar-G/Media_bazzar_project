<?php

namespace App\Notifications;

use Illuminate\Bus\Queueable;
use Illuminate\Contracts\Queue\ShouldQueue;
use Illuminate\Notifications\Messages\MailMessage;
use Illuminate\Notifications\Notification;

class MailSetPasswordNotification extends Notification
{
    use Queueable;

    private $token;
    private $email;
    private $password;


    /**
     * Create a new notification instance.
     *
     * @return void
     */
    public function __construct($token, $email, $password)
    {
        $this->token = $token;
        $this->email = $email;
        $this->password = $password;
    }

    /**
     * Get the notification's delivery channels.
     *
     * @param  mixed  $notifiable
     * @return array
     */
    public function via($notifiable)
    {
        return ['mail'];
    }

    /**
     * Get the mail representation of the notification.
     *
     * @param  mixed  $notifiable
     * @return \Illuminate\Notifications\Messages\MailMessage
     */
    public function toMail($notifiable)
    {
        return(new MailMessage)
           ->subject('Set your password')
           ->line("Your auto generated password is **{$this->password}**. You can reset your password from the link bellow:")
           ->action('Reset Password', route('password.reset', [$this->token, 'email' => $this->email]));
    }

    /**
     * Get the array representation of the notification.
     *
     * @param  mixed  $notifiable
     * @return array
     */
    public function toArray($notifiable)
    {
        return [
            //
        ];
    }
}
