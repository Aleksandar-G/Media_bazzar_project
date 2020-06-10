<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateWorkerPreferencesTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('worker_preferences', function (Blueprint $table) {
            $table->id();
            $table->unsignedBigInteger('worker_id');
            $table->date('start_date');
            $table->date('end_date');
            $table->integer('shifts_per_week');
            $table->timestamps();

            $table->foreign('worker_id')->references('id')->on('workers');
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::table('worker_preferences', function (Blueprint $table) {
            $table->dropForeign(['worker_id']);
        });

        Schema::dropIfExists('worker_preferences');
    }
}
