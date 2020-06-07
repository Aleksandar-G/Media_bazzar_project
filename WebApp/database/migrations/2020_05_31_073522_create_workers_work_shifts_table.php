<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateWorkersWorkShiftsTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('workers_work_shifts', function (Blueprint $table) {
            $table->id();
            $table->unsignedBigInteger('worker_id');
            $table->unsignedBigInteger('work_shift_id');

            $table->index(['id', 'worker_id', 'work_shift_id']);
            $table->foreign('worker_id')->references('id')->on('workers');
            $table->foreign('work_shift_id')->references('id')->on('work_shifts');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::table('workers_work_shifts', function (Blueprint $table) {
            $table->dropForeign(['worker_id']);
            $table->dropForeign(['work_shift_id']);
            $table->dropIndex(['id', 'worker_id', 'work_shift_id']);
        });

        Schema::dropIfExists('workers_work_shifts');
    }
}
