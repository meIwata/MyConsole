using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//DirectoryInfo/FileInfo ->Stream 對應物件 操作相對目錄
namespace MyConsole
{
    internal class TestStreamRW
    {
        //Entry point
        public static void Main()
        {
            //提示 輸入目錄到檔案
            Console.WriteLine("請輸入目錄檔案名稱:");
            String fileName = Console.ReadLine();

            //建立FileInfo物件
            FileInfo file = new FileInfo(fileName); //也有可能不存在，建立一個物件邏輯應對 不具有Open(走向Stream)
            if (file.Exists) {
                //處理
                Console.WriteLine("檔案存在");
            }
            else
            {
                //提示不存在
                Console.WriteLine("檔案不存在");
            }
        }
    }
}
