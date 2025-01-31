using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//讀寫圖片檔案(二進位檔案) BLOB(Binary Large Object) 非結構式檔案
namespace MyConsole
{
    internal class ReadWriteImageFile
    {
        //Entry Point
        public static void Main() {
            //輸出圖片檔名稱
            Console.WriteLine("請輸入圖片檔名稱:");
            String fileName = Console.ReadLine();

            //設定目錄到檔案名稱，這裡是照片放的地方。根據自己的位置調整代碼
            //String path = $"C:\\Users\\lulul\\Downloads\\{fileName}.jpg"; //這樣也可以
            String path = $@"C:\Users\lulul\Downloads\{fileName}.jpg"; // \ escape character

            Stream fs = null; //要給預設值，因為他不一定開啟成功
            Stream outFs = null;
            //開啟
            try
            {
                //開啟檔案Stream
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);

                //讀取檔案byte(s)->Byte[] 陣列空間
                Byte[] buffer = new Byte[fs.Length];

                //讀取檔案至緩衝區
                fs.Read(buffer, 0, buffer.Length); //從第一個位置讀到最後一個位置。但這裡如果奘到例外不能讀取...


                Console.WriteLine($"檔案讀取成功...{buffer.Length}");
                //寫出去...建立FileStream方向開啟 建立/同時具有開啟  (這邊檔案也是放在跟來源一樣的地方，先建立的名稱取名XXX_copy)
                outFs = new FileStream($@"C:\Users\lulul\Downloads\{fileName}_copy.jpg", FileMode.Create, FileAccess.Write);

                //寫入檔案
                outFs.Write(buffer, 0, buffer.Length);

                //清除緩存區
                outFs.Flush();

                //關閉檔案也是要寫到finally去

            }
            catch (FileNotFoundException ex)
            { //子類別先寫
                Console.WriteLine("檔案不存在");

            }
            catch (IOException ex)
            { //父類別放後面
                Console.WriteLine("檔案存取錯誤");

            }
            finally
            { //正常或者產生例外也要到這裡
                //關閉檔案
                if (fs != null) //不是空值進行關閉
                {
                    Console.WriteLine("關閉檔案");
                    fs.Close();
                }

                //關閉檔案
                if (outFs != null) //不是空值進行關閉
                {
                    Console.WriteLine("關閉輸出檔案");
                    outFs.Close();
                }
            }
        }   
    }
}