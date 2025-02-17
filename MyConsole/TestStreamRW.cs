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
                    //取出Path
                    String path = file.Directory.FullName;
                    Console.WriteLine("檔案路徑: " + path);
                    //寫出去 建立新檔案 操作FileInfo物件來完成
                    //原來開啟檔案檔案名稱 取出檔名 延伸一個新檔名
                    String name = file.Name.Remove(file.Name.LastIndexOf('.')); //取出檔案名，不要副檔名
                    Console.WriteLine(name);
                    String newFile = $@"{path}\{name}_copy.jpg";
                    //建立FileInfo物件
                    FileInfo newFileInfo = new FileInfo(newFile); //邏輯對應
                    //建立新檔案
                    newFileInfo.Create();


                    //Console.WriteLine(file.Name); //先印出他的檔名
                    //FileInfo newFile = new FileInfo(@"D:\IDP\new.txt");
                }
                catch (IOException ex) { 
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