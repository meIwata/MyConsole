using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//規劃員工類別 雛形
namespace MyConsole.Models
{
	//設定public修飾詞(Modifier) 可見度(影響如何被看見 被使用或者被衍生當作父類別)
	//public 公開的 可以被看見 可以被使用 可以被衍生類別(專案)
	//父親是採用Object
	public class Employees
	{
		//Data Field(可以儲存資訊)特徵
		//先不考慮封裝性，先開放都可以存取
		public Int32 id; //員工編號
		public String name; //員工姓名

		//透過修飾詞private來保護資料(封裝在這一個類別內部，或者產生個體物件內部)
		private Int32 _salary; //要封裝的名稱需改成底線命名
		public String address; //員工地址
		public String phone; //員工電話
		
		//設定滿18歲才能設定生日
		private DateTime _birthdate; //要封裝的名稱需改成底線命名

		//實際薪水Data Field需要保護起來，不被更改
		private Int32 _actSalary; //要封裝的名稱需改成底線命名，待會封裝只給getter，只能讀不能設定


		//共用資料欄Data Field(靜態)  class member，如果規劃不能改的常數，就要寫成const，隱含為static
		//public static String companyName = "巨匠電腦";
		public const String COMPANYNAME = "巨匠電腦"; //常數不能改，一般常數命名為大寫
		//public static String companyAddress = "台北市公園路"; //可以改變
		private static String _companyAddress = "台北市公園路"; //把地址保護起來，改成private，需要封裝的名稱需改成底線命名


		//編譯會產生預設建構子Constructor(空參數的)

		//Instance Property(物件屬性) 透過物件進行存取
		//規劃屬性 Property(代理一個被封裝資料欄位) 可以雙向setter and getter (也可以單向)
		public Int32 salary { //正式名稱留給代理

			//設定區段 Setter
			set {
				if (value > 30000)
				{ //如果值大於30000
					_salary = value; //就把值賦予 _salary
				}
				else {
					_salary = 30000; //如果沒有大於30000，直接設成30000
				}
			}

			//取得 Getter，就有回應
			get{
				return _salary;
			}
		}

		//定義屬性 static 問出公司地址getter 唯讀屬性
		public static String companyAddress
		{
			get
			{
				return _companyAddress;
			}

			/*
			set {
				_companyAddress = value; 
			}
			*/
		}

		//生日屬性Property(滿18歲才能設定)
		public DateTime birthdate{ 
			
			//設定
			set{
				//取出系統日期 static Now Property getter
				DateTime today = DateTime.Now;

				//輸入生日與今天差異計算
				TimeSpan span = today - value;

				int year = (Int32)(span.Days / 365.25);

				//判斷是否滿18
				if (year >= 18) { 
					_birthdate = value;
				}
			}

			//取得
			get { 
				return _birthdate;
			}
		}

		//精靈產生出來的，使用lambda進行屬性的實作
		public int actSalary { get => _actSalary; } //實際薪水只能讀不能設定，所以setter刪掉，命名部分更改成actSalary
		//也可以寫成這樣
		/*
		public int actSalary {
			get { 
			return _actSalary; 
			}
		}
		*/

		//薪資核算方法 Method - 月薪制 (針對Employee的功能)
		public void calSalary(Int32 days, Int32 bonus) //第一行定義 抽象描述，這裡不寫static，因為他是個別物件存在方法
		{
			//出勤天數
			if (days > 0) { //出勤天數至少要>0，才進行薪資核算
				_actSalary = (Int32)(days / 22.0 * _salary) + bonus; //記得這裡要寫22.0，因為如果21/22，會取整數(0)回來，(裡面變成double)，前面加上(Int32)轉型成整數
			}
		}//大括號就是功能的實作
	}
}