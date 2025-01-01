using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//存取MSSQL Servver 資料庫資料表Employees
namespace MyConsole.Models
{
    //實作介面IDao<T,K> 介面 實作方法與屬性 不完成實作 類別必須要抽象類別
    //public class EmployeesDao : Object, IDao<Employees, Int32> //也可以寫成這樣
    public class EmployeesDao : IDao<Employees, Int32>
    {   
        //Data Field
        private IDbConnection _connection;

        public IDbConnection Connection { //屬性的實作
            set{
                _connection = value;
            }
            get{
                return _connection; 
            }
        }

        public bool delete(Int32 id)
        {
            throw new NotImplementedException();
        }

        public Employees get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employees> getAll()
        {
            throw new NotImplementedException();
        }

        public bool insert(Employees entity)
        {
            throw new NotImplementedException();
        }

        public bool update(Employees entity)
        {
            throw new NotImplementedException();
        }
    }
}