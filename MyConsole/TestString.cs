using System; //引用系統命名空間
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
	internal class TestString
	{
		//主程式 Entry Point static(Global公有)修飾詞 直接抽出來執行
		public static void Main()
		{ //C#不寫String[]args也可

			Int32 salary = 50000; //結構是值型別
								  //類別是參考型別 Reference Type
								  //建構Constructor一個個體字串物件
								  //Class就是Data Type
			String name; //定義一個區域變數 類型String

			//建構一個字串物件
			//name = "Eric"; //賦值Assign。先建構一個字串物件，然後再把位置指派給name
			name = new String(new Char[] { 'E', 'r', 'i', 'c' }); //把字元集合變成一個字串物件建起來，再把位置塞給name

			//輸出
			Console.WriteLine(name); //name變數儲存地址 參考那一個字串 進行輸出

			//操作物件 屬性Proeprty or Method or Data Field or UI Event...
			//操作個別物件屬性 Instance Property
			Int32 len = name.Length;
			Console.WriteLine(len);

			//操作物件方法 Method
			String newName = name.ToUpper(); //轉大寫方法呼叫 產生一個新的字串物件
			Console.WriteLine(name);
			Console.WriteLine(newName);

			Type t = name.GetType(); //取得物件型別 GetType() 繼承來自跟類別Object
			Console.WriteLine(t);
		}
	}
}