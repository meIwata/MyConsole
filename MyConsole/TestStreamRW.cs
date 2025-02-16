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
                //存在
                Console.WriteLine("檔案存在");
                //處理(開啟檔案Stream)，但有可能檔案打不開所以要做例外管理
                try {
                    Stream fs = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);
                    
                    //讀取檔案內容--先準備一下緩存區 Byte陣列
                    Byte[] buffer = new byte[fs.Length];
                    //讀取圖片內容到緩存區去
                    fs.Read(buffer, 0, buffer.Length); //從0讀取到最後。可能沒有權限讀取
                    
                    //關閉Stream
                    fs.Close();
                    Console.WriteLine("讀取檔案內容成功");
                }
                catch(IOException ex) { 
                    Console.WriteLine("開啟檔案失敗，可能是權限不足");
                }
            }
            else
            {
                //提示不存在
                Console.WriteLine("檔案不存在");
            }
        }
    }
}