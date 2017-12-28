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

    public function GetURL(Request $request)
    {
    	// if ($request->isMethod('post'))
    	// {
    	// 	echo "Get method";
    	// }
    	// else
    	// {
    	// 	echo "Not get method";
    	// }
    	return $request->url();
    }

    public function postForm(Request $request)
    {
    	// echo "Ten cua ban la: <br>";
    	// echo $request->HoTen;
    	if ($request->has('Tuoi'))
    	{
    		echo "Co tham so tuoi";
    	}
    	else 
    	{
    		echo "Khong co tham so tuoi";
    	}
    }
}
