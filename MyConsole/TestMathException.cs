using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//呼叫共用模組 方法 進行除法運算
namespace MyConsole
{
    internal class TestMathException
    {
        //Entry Point
        public static void Main() {
            //主控台標準輸入與輸出
            Console.WriteLine("輸入分子:");
            String value = Console.ReadLine();

            //提示
            Console.WriteLine("請輸入分母:");
            String baseValue = Console.ReadLine();

            //轉換將字串物件轉換結構整數Int32
            Int32 v = Int32.Parse(value);
            Int32 b = Int32.Parse(baseValue);

            //進行除法運算
            Int32 result = v / b; //這裡也可能產生例外 除數為0

            //輸出結果
            Console.WriteLine($"{v}/{b} = {result}");
        }
    }
}
