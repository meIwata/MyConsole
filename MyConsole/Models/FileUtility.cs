using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole.Models
{
    public class FileUtility
    {
        //Global static method(全域靜態方法)
        //讀取圖檔檔案
        public static Byte[] readImage(String fileName) {
            //1.建構一個File Stream

            Stream fs = null;
            Byte[] buffer = null;
            try {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read); //開啟檔案，以唯讀模式開啟，不允許寫入。

                //讀取檔案byte(s)->Byte[] 陣列空間
                buffer = new Byte[fs.Length];

                //讀取檔案
                fs.Read(buffer, 0, buffer.Length); //如果這裡撞到例外 不能讀取

            } catch (FileNotFoundException ex) {
                //拋出例外(呼叫端)
                throw ex;
            }
            catch (IOException ex) {
                throw ex;

            } finally {
                if (fs != null) {
                    Console.WriteLine("關閉檔案");
                    fs.Close();
                }

            }
            return buffer; //成功讀取後，回傳 buffer，內含檔案的所有位元組。
        }
    }
}
