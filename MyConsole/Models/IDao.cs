using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//規範對資料CRUD的操作(Creat, Read, Update, Delete)
namespace MyConsole.Models
{
    //Generic Type(泛型) 實作接頭T
    public interface IDao<T,K> //T 被用來表示資料庫操作的實體，映射某一個資料表的全部東西，K 則是主鍵的類型(int)
    {
        //介面的方法預設為抽象方法
        //C# 介面不能進行修飾詞的
        Boolean insert(T entity); //傳遞一個物件進來新增(T Generic Type) 實作時再來決定吧
        Boolean update(T entity);
        Boolean delete(K id);
        T get(K id); //傳遞一個物件進來查詢(K Generic Type) 實作時再來決定吧
        List<T> getAll(); //查詢所有資料

        //抽象屬性Property 定義注入連接物件(類別)
        IDbConnection Connection { get; set; } //實作Property Injection 注入連接物件
    }
}