using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////無須屬性設定邏輯 採用自動屬性(屬性寫成抽象 沒有設定Data Field) 編譯自動實作屬性與產生對應資料欄位
namespace MyConsole.Models
{
    public class Customers
    {
        //原本應該要這樣寫
        /*
        private String _customerId;
        public string CustomerId { get => _customerId; set => _customerId = value; }
        */

        //現在寫成抽象屬性 自動實作屬性（Auto-Implemented Properties）
        public String customerId { get; set; } //顧客編號
        public String companyName { get; set; } //公司名稱
        public String address { get; set; } //公司地址
        public String phone { get; set; } //公司電話
        public String country { get; set; } //公司國家
        //這再編譯的時候會產生資料欄
    }
}