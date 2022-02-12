using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket
{
    internal class DataBase
    {
        public static Dictionary<int, Book> Db = new Dictionary<int, Book>();


        static void AddDb(Book item)
        {
            Db.Add(item.Id, item);
        }

        static void ShowAnbar()
        {
            foreach(var item in Db)
            {
                Console.Write($"Id.{item.Key}\nProduct Name: {item.Value.Name}\nProduct Price: {item.Value.Price}\n" +
                    $"PageSize: {item.Value.PageSize}\nProduct size in Stock: {item.Value.InStock}\nBook Genre: {item.Value.Genre}\n");
            }
        }

        static void ChangName(Book book) // Each Field need his own change method
        {
           foreach(var item in Db)
            {
                if (item.Key == book.Id)
                {
                    
                }
            }
        }




    }
}
