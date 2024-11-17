using MyConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//測試業務員與員工
namespace MyConsole
{
    internal class TestSalesEmployees
    {
        public static void Main() 
        {
            Employees emp1 = new Employees()
            {
                id = 1,
                name = "Eric",
                address = "Taipei",
                birthdate = new DateTime(2001, 1, 1),
                salary = 50000
            }; //物件初始化

            //建構一個業務員物件
            Sales sales1 = new Sales(2, "Linda", "Taipei", 60000, 1000000)
            {
                phone = "0912345678",
                birthdate = new DateTime(2002, 1, 1)
            }; //物件初始化


            //輸出
            Console.WriteLine($"編號:{emp1.id} 姓名:{emp1.name} 底薪:{emp1.salary} 生日:{emp1.birthdate}");
            Console.WriteLine($"編號:{sales1.id} 姓名:{sales1.name} 底薪:{sales1.salary} 生日:{sales1.birthdate} 業績:{sales1.SalesAmount}");
        }
    }
}
