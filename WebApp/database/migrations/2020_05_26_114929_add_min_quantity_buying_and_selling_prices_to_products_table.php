<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class AddMinQuantityBuyingAndSellingPricesToProductsTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::table('products', function (Blueprint $table) {
            $table->dropColumn('price');
            $table->decimal('buying_price', 8, 2, true);
            $table->decimal('selling_price', 8, 2, true);
            $table->integer('min_quantity');
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::table('products', function (Blueprint $table) {
            $table->decimal('price', 8, 2, true);
            $table->dropColumn('buying_price');
            $table->dropColumn('selling_price');
            $table->dropColumn('min_quantity');
        });
    }
}
