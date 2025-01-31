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
        //設定第三個參數 將回應值改換 By Reference(傳址) 參數
        public static Boolean Division(Int32 v, Int32 b, out Int32 result) {

            Boolean resultFlag = false;
            //進行例外管理(分母是0)
            try {
                //進行除法運算
                result = v / b; //這裡也可能產生例外 除數為0
                resultFlag = true; //運算成功就是true

            }
            catch (DivideByZeroException ex) {
                //Logging...
                result = -1;
            }
            return resultFlag;
        }
    }
}