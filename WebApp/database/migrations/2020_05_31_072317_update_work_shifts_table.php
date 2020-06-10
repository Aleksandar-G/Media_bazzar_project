<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class UpdateWorkShiftsTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::table('work_shifts', function (Blueprint $table) {
            $table->dropForeign(['worker_id']);
            $table->dropColumn('worker_id');

            $table->integer('workers_needed');
            $table->decimal('wage', 8, 2, true);
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::table('work_shifts', function (Blueprint $table) {
            $table->unsignedBigInteger('worker_id');
            $table->foreign('worker_id')->references('id')->on('workers');

            $table->dropColumn('workers_needed');
            $table->dropColumn('wage');
        });
    }
}
