<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});

Route::get('KhoaHoc', function() {
	return "Xin chao cac ban";
});

Route::get('KhoaPham/Laravel', function() {
	echo "XIN CHAO CAC BAN";
});

//truyen tham so tren route
Route::get('HoTen/{ten}', function($ten){
	echo "Ten cua ban la: ".$ten;
});

//truyen tham so co dieu kien tren route
Route::get('NgaySinh/{ngaysinh}', function($ngaysinh)
{
	echo "Ngay sinh: ".$ngaysinh;
})->where(['ngaysinh'=>'[0-9]+']);