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

			//使用建構子進行初始化 設定員工編號 姓名 地址
			Employees emp3 = new Employees(3, "Tom", "Taipei")
			{
				phone = "0911222333",
				birthdate = new DateTime(2003, 10, 5),
				salary = 30000
			}; //Object Initializer 物件初始化器


			//核算薪水 呼叫物件方法
			emp1.calSalary(22, 10000);
			emp2.calSalary(22, 10000);
			emp3.calSalary(22, 10000);

			//輸出
			Console.WriteLine($"編號:{emp1.id} 姓名:{emp1.name} 底薪:{emp1.salary} 實際薪資:{emp1.actSalary} 生日:{emp1.birthdate}");
			Console.WriteLine($"編號:{emp2.id} 姓名:{emp2.name} 底薪:{emp2.salary} 實際薪資:{emp2.actSalary} 生日:{emp2.birthdate}");
			Console.WriteLine($"編號:{emp3.id} 姓名:{emp3.name} 底薪:{emp3.salary} 實際薪資:{emp3.actSalary} 生日:{emp3.birthdate}");
		}
	}
}