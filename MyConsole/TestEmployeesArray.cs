using MyConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//收集各類型的員工們(陣列) Employees/Engineer/Sales
namespace MyConsole
{
    internal class TestEmployeesArray
    {
        //Entry Point
        public static void Main() {

            //陣列是同類型集合 使用型別語法
            Employees[] emps = new Employees[4]; //用基底類型Employees，有4個員工
            
            //建構員工們
            //第一個員工
            emps[0] = new Employees(1, "張三豐", "台北市")
            {
                birthdate = new DateTime(2001, 1, 1),
                phone = "0912345678",
                salary = 50000
            }; //物件初始化
            //第二個員工，業務員
            emps[1] = new Sales(2, "李四", "台北市", 40000, 1000000)
            {
                phone = "0912345678",
                birthdate = new DateTime(2002, 1, 1)
            };
            //第三個員工，業務員
            emps[2] = new Sales(3, "王五", "台北市", 1000000)
            {
                phone = "0912345678",
                birthdate = new DateTime(2003, 1, 1),
                salary = 30000 //繼承來自Employees Property
            };
            //第四個員工，建構工程師
            emps[3] = new Engineer(4, "趙六", "台北市", 60000, "C#", 10000)
            {
                phone = "0912345678",
                birthdate = new DateTime(2004, 1, 1)
            };

            //走訪每一個員工(通稱為員工Employees)
            foreach (Employees emp in emps) {
                
                //判斷本尊是否業務員
                if (emp is Sales) {
                    //明確性轉型Explicit casting
                    ((Sales)emp).ActSalesAmount = 1000000;
                    //業績獎金核算
                    ((Sales)emp).calCommision();
                }

                //輸出
                if (emp is Sales)
                { //如果是業務員
                    Sales s1 = (Sales)emp; //轉型成Sales
                    Console.WriteLine($"編號:{s1.id} 姓名:{s1.name} 底薪:{s1.salary}  生日:{s1.birthdate} 實際業績:{s1.ActSalesAmount} 業績獎金:{s1.Commission}");
                }
                else if (emp is Engineer)
                { //如果是工程師
                    Engineer s1 = (Engineer)emp; //轉型成Engineer
                    Console.WriteLine($"編號:{s1.id} 姓名:{s1.name} 底薪:{s1.salary}  生日:{s1.birthdate} 技術工作:{s1.Tech} 技術津貼:{s1.TechBons} 實際薪水:{s1.actSalary} ");
                }
                else {
                    Console.WriteLine($"編號:{emp.id} 姓名:{emp.name} 底薪:{emp.salary}  生日:{emp.birthdate} 實際薪水:{emp.actSalary} ");
                }
            }
        }
    }
}