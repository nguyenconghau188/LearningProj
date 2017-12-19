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

//dat dinh danh cho route
Route::get('Route1', ['as'=>'MyRoute', function() {
	echo "Xin chao cac ban";
}]);

Route::get('Route2', function(){
	echo "Day la route2";
})->name('MyRoute2');

//goi route bang redirect
Route::get('GoiTen', function(){
	return redirect()->route('MyRoute');
});

Route::get('GoiTen2', function(){
	return redirect()->route('MyRoute2');
});

//tao Group route
Route::group(['prefix'=>'MyGroup'], function(){
	Route::get('User1', function(){
		return "User1";
	});
	Route::get('User2', function(){
		return "User2";
	});
	Route::get('User3', function(){
		return "User3";
	});
});

//goi controller
Route::get('GoiController', 'MyController@XinChao');