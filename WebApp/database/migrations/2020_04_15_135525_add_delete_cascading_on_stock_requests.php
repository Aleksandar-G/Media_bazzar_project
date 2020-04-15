<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class AddDeleteCascadingOnStockRequests extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::table('stock_requests', function (Blueprint $table) {
            $table->unsignedBigInteger('worker_id')->nullable()->change();
            $table->dropForeign(['worker_id']);
            $table->foreign('worker_id')
                ->references('id')->on('workers')
                ->onDelete('set null')
                ->change();

            $table->dropForeign(['product_id']);
            $table->foreign('product_id')
                ->references('id')->on('products')
                ->onDelete('cascade')
                ->change();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        //
    }
}
