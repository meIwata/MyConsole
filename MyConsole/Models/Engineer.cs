using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//工程師是員工
namespace MyConsole.Models
{
    //繼承父類別Employees
    public class Engineer: Employees //Engineer繼承Employees
    {
        //Data Field
        private Int32 _techBons; //技術津貼
        private String _tech; //技術

        //自訂建構子
        public Engineer(Int32 id, String name, String address, Int32 salary, String tech, Int32 techBons):base(id, name, address) { 
            
            //設定底薪
            this.salary = salary; //父親屬性salary進行設定
            this._tech = tech;
            this._techBons = techBons;
        }


        //Property設定
        public int TechBons { get => _techBons; set => _techBons = value; } //可以設定也可以取得
        public string Tech { get => _tech; set => _tech = value; }
    }
}
