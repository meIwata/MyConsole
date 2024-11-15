using MyConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//個體員工物件薪資核算方法
namespace MyConsole
{
	internal class TestEmployeesMethod
	{
		//Entry Point
		public static void Main()
		{
			//設定一個區域變數
			//預設建構子
			Employees emp1 = new Employees(); //建構一個員工物件
			//參考物件 設定相關Data Field/Property 
			emp1.id = 1; //設定員工編號
			emp1.name = "Eric"; //設定員工姓名
			emp1.salary = 50000; //設定員工薪資
			emp1.address = "Taipei"; //設定員工地址
			emp1.phone = "0912345678"; //設定員工電話
			emp1.birthdate = new DateTime(2001, 1, 1); //設定員工生日

			Employees emp2 = new Employees(); //建構一個員工物件
			emp2.id = 2; //設定員工編號
			emp2.name = "Linda"; //設定員工姓名
			emp2.salary = 40000; //設定員工薪資
			emp2.address = "Taipei"; //設定員工地址
			emp2.phone = "0912345678"; //設定員工電話
			emp2.birthdate = new DateTime(2002, 1, 1); //設定員工生日
		}
	}
}