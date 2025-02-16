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
            String fileName = @"C:\Users\lulul\Downloads";

            //Exists static method判斷目錄是否存在
            if (Directory.Exists(fileName)) { 
                // 存在
                Console.WriteLine("目錄存在");
            }else {
                // 不存在
                Console.WriteLine("目錄不存在");
            }
        }
    }
}
