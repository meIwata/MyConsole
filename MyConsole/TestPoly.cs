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

            //招募進來是一個業務員(基底類別 類型 父親類型 建構子類別物件)
            emp1 = new Sales(1, "Allen", "高雄市", 50000, 1000000);

        }
    }
}