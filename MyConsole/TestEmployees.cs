using MyConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//建構自行規劃類別 Employees
namespace MyConsole
{
	internal class TestEmployees
	{
		//Entry Point
		public static void Main()
		{
			//定義區域變數，類別是參考型別
			Employees emp1 = null; //先放null空值做參考

			//建構一個員工物件 使用預設件建構子Default Constructor
			emp1 = new Employees(); //建構一個員工物件
									//物件沒有被參考會被GC回收掉

			//使用變數參考位址操作這一個個體(員工物件)
			emp1.id = 1;
			emp1.name = "Eric";
			//透過應用系統進行驗證...
			emp1.salary = 50000; //這裡是執行 Setter
			emp1.address = "Taipei";
			emp1.phone = "0912345678";
			emp1.birthdate = new DateTime(2011, 1, 1); //這裡的物件資料不合理

			int s = emp1.salary; //這裡是執行 Getter

			//輸出
			Console.WriteLine($"編號:{emp1.id} 姓名:{emp1.name} 底薪:{s} 生日:{emp1.birthdate}");

			//操做員工繼承下來的功能
			Console.WriteLine(emp1.ToString()); //呼叫Object類別ToString()方法

			//直接問類別static 共用資料欄 問公司是?
			//Employees.COMPANYNAME = "鴻海"; //常數不能改
			Console.WriteLine(Employees.COMPANYNAME); //問公司名稱

			//透過 static 屬性問公司地址
			/*Employees.companyAddress = "台中市福星路";*/
			Console.WriteLine(Employees.companyAddress); //問公司地址
			

		}
	}
}