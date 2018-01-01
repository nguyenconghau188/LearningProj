<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Http\Response;

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

    public function setCookie()
    {
    	$response = new Response();
    	$response->withCookie('KhoaHoc', 'Laravel - Khoa Pham', 1);
    	return $response;
    }

    public function getCookie(Request $request)
    {
    	return $request->cookie('KhoaHoc');
    }

    //upload file
    public function postFile(Request $request)
    {
    	if($request->hasFile('myFile'))
    	{
    		//echo "Da co file";
    		$file = $request->file('myFile');
    		if ($file->getClientOriginalExtension('myFile') == "JPG")
    		{

    			$fileName = $file->getClientOriginalName('myFile');
    			$file->move('image', $fileName);	
    			echo "Da luu file :".$fileName;
    		}
    		else
    		{
    			echo "Khong duoc phep upload file";
    		}

    	}
    	else
    	{
    		echo "Chua co file";
    	}
    }

    //json
    public function getJson()
    {
    	$array = ['KhoaHoc'=>'Laravel-KhoaPham'];
    	return response()->json($array);
    }
}
