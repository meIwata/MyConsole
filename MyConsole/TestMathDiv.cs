using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//呼叫共用模組 方法 進行除法運算
namespace MyConsole
{
    internal class TestMathDiv
    {   
        //Entry Point
        public static void Main() {
            //輸入
            Console.WriteLine("輸入分子:");
            String value = Console.ReadLine();
            Console.WriteLine("請輸入分母:");
            String baseValue = Console.ReadLine();

            //轉換(呼叫static method 內含例外管理)
            Int32 v;
            if (Int32.TryParse(value, out v)) { //TryParse是布林值，如果value轉的過去就傳v
                Int32 b;
                //進行分母值轉換
                if (Int32.TryParse(baseValue, out b)) { //如果baseValue轉的過去就傳b
                    //進行運算
                    //Math.Division(v, b); //用的是.Net的類別
                    Int32 result = MyConsole.Models.Math.Division(v, b); //使用自己命名空間的類別
                    
                    //輸出
                    Console.WriteLine("答案: " + result);
                } else {
                    Console.WriteLine("分母轉換失敗");
                }
            } else {
                Console.WriteLine("分子轉換失敗");
            }
        }
    }
}
