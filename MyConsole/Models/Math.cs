using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//算術類別
namespace MyConsole.Models
{
    public class Math
    {
        //除法運算 無須個別物件操作(參數進來 處理之後 回應值)
        //satatic 關鍵字 無須個別資訊處理 static 直接抽出來 進行執行
        //class Member(Non Instance Method)
        public static Int32 Division(Int32 v, Int32 b) { 
            //進行除法運算
            Int32 result = v / b;
            return result;
        }
    }
}