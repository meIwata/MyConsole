using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//操作Directory類別共用功能  DirectoryInfo 對應物件 操作相對目錄
namespace MyConsole
{
    internal class TestDirectory
    {
        //Entry point
        public static void Main() {
            //判斷指定目錄是否存在??
            //String fileName = @"C:\Users\lulul\Downloads";
            String fileName = "C:\\Users\\lulul\\Downloads123"; // 兩種寫法

        

            //Exists static method判斷目錄是否存在
            if (Directory.Exists(fileName)) { 
                // 存在
                Console.WriteLine("目錄存在");

                //找到目錄後，要開啟個體物件對應DirectoryInfo
                //建構一個DirectoryInfo物件
                DirectoryInfo dir = new DirectoryInfo(fileName);
                
                //取出該目錄屬性(Attribute)
                FileAttributes atts = dir.Attributes; //取回列舉(目錄類型)
                Console.WriteLine("目錄屬性: " + atts);

                //可以繼續查詢，查詢建立時間
                DateTime createDate = dir.CreationTime;
                Console.WriteLine("建立時間: " + createDate);

                //取出目錄下所有檔案
                FileInfo[] files = dir.GetFiles();
                //走訪每一個檔案(FileInfo)物件
                foreach (FileInfo file in files) {
                    Console.WriteLine("檔案名稱:" + file.Name);
                    Console.WriteLine("檔案大小:" + file.Length);
                    Console.WriteLine("檔案建立時間:" + file.CreationTime);
                }
            }
            else {
                // 不存在
                Console.WriteLine("目錄不存在");
                //建立目錄 使用Directory類別的static CreateDirectory方法
                DirectoryInfo newDir = Directory.CreateDirectory(fileName);

                if (newDir.Exists) { // 用屬性來問出來
                    Console.WriteLine("目錄建立成功"); // 要測試成功，上面路徑要改
                }
                else{
                    Console.WriteLine("目錄建立失敗");
                }
            }
        }
    }
}
