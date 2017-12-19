<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class MyController extends Controller
{
    //tao function
    public function XinChao()
    {
    	echo "Chao cac ban";
    }

    //truyen tham so cho function
    public function KhoaHoc($ten)
    {
    	echo "Khoa hoc: ".$ten;
    	//redirect ve Route1
    	return redirect()->route('MyRoute');
    }
}
