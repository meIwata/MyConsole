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

            //會有較大機會是從轉換這邊有例外出現，就從這裡以下來管理
            try { 
            //轉換將字串物件轉換結構整數Int32 (這裡會產生格式無法轉換例外)
            Int32 v = Int32.Parse(value);
            Int32 b = Int32.Parse(baseValue);

            //進行除法運算
            Int32 result = v / b; //這裡也可能產生例外 除數為0

            //輸出結果
            Console.WriteLine($"{v}/{b} = {result}");
            } catch (FormatException ex){ //捕捉例外
                //TODO進行管理 (進行Logging紀錄)
                Console.WriteLine("錯誤: " +  ex.Message );//核心的錯誤給使用者看不是非常人性化的設計
            }
            //設定第二種例外處理
            catch (OverflowException ex){
                Console.WriteLine("錯誤: " + ex.Message);
            }
            //最後這裡可以放所有例外的父類別Exception
            catch (Exception ex){ //父類例外物件要寫在最後
                Console.WriteLine("錯誤: " + ex.Message);
            }
        }
    }
}
