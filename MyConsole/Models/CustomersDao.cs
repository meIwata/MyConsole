using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole.Models
{
    public class CustomersDao : IDao<Customers, String>
    {   
        //Data Field
        private IDbConnection _connection;
        public IDbConnection Connection{
            
            //傳統的 get 和 set
            /*
            set {
                _connection = value;
            }
            get { 
                return _connection; 
            */

            //Lambda語法
            set => _connection = value;
            get => _connection;
        }

        public bool delete(string id)
        {
            throw new NotImplementedException();
        }

        public Customers get(string id)
        {
            throw new NotImplementedException();
        }

        public List<Customers> getAll()
        {
            throw new NotImplementedException();
        }

        public bool insert(Customers entity)
        {
            throw new NotImplementedException();
        }

        public bool update(Customers entity)
        {
            throw new NotImplementedException();
        }
    }
}