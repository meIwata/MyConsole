using MyConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//建構員工們_只知道員工 來的物件是Sales或者Engineer
namespace MyConsole
{
    internal class TestPoly
    {
        //Entry Point
        public static void Main(){

            //變數定義 採用公版(基底類別) 來定義
            Employees emp1 = null;
            Employees emp2 = null;

            //招募進來是一個業務員(基底類別 類型 父親類型 建構子類別物件)
            emp1 = new Sales(1, "Allen", "高雄市", 50000, 1000000);
            //招募進來是一個工程師(基底類別 類型 父親類型 建構子類別物件)
            emp2 = new Engineer(2, "Bill", "台中市", 60000, "C#", 10000);

            //站在員工類型 操作這一個業務員
            emp1.birthdate = new DateTime(2001, 1, 1);
            //站在員工類型 操作這一個工程師
            emp2.birthdate = new DateTime(2002, 1, 1);

            //設定實際業績?? 物件不可變 變數換個角色吧
            ((Sales)emp1).ActSalesAmount = 1000000; //執行階段的轉型

            //業績獎金核算
            ((Sales)emp1).calCommision();

            //核算薪資
            emp1.calSalary(22, 10000); //會不會沒有加上業績獎金
            //核算薪資
            emp2.calSalary(22, 10000); //會不會沒有加上技術津貼

            //輸出 員工資訊 問實際薪水
            Console.WriteLine($"業務員編號:{emp1.id} 姓名:{emp1.name} 底薪:{emp1.salary}  生日:{emp1.birthdate} 實際薪資:{emp1.actSalary}");
            Console.WriteLine($"工程師編號:{emp2.id} 姓名:{emp2.name} 底薪:{emp2.salary}  生日:{emp2.birthdate} 實際薪資:{emp2.actSalary}");
        }
    }
}