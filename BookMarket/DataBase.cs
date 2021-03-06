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


        public static void AddDb(Book item)
        {
            Db.Add(item.Id, item);
        }

        public static void ShowAnbar()
        {
            foreach(var item in Db)
            {
                Console.Write($"Id.{item.Key}\nProduct Name: {item.Value.Name??"Unknown"}\nProduct Price: {item.Value.Price}\n" +
                    $"PageSize: {item.Value.PageSize}\nProduct size in Stock: {item.Value.InStock}\nBook Genre: {item.Value.Genre??"Unknown"}\n");
            }
        }

        public static void ChangeInfo(int id, string new_value,char choice) // Each Field need his own change method
        {
            switch (choice)
            {
                case 'n':
                    foreach (KeyValuePair<int, Book> item in Db)
                    {
                        if (item.Key == id)
                        {
                            Console.WriteLine($"{item.Value.Name} book has been changed to {new_value}");
                            Console.ReadLine();

                            item.Value.Name = new_value;
                            break;
                            
                        }
                    }
                    break;
                case 'g':
                    foreach (KeyValuePair<int, Book> item in Db)
                    {
                        if (item.Key == id)
                        {
                            Console.WriteLine($"{item.Value.Genre} book has been changed to {new_value}");
                            Console.ReadLine();
                            item.Value.Genre = new_value;
                            break;
                        }
                    }
                    break;

            }
         
        }

       

        public static void ChangeInfo(int id, int new_value,char choice) // Each Field need his own change method
        {
            switch (choice)
            {
                case 'p':
                    foreach (KeyValuePair<int, Book> item in Db)
                    {
                        if (item.Key == id)
                        {
                            Console.WriteLine($"{item.Value.PageSize} book has been changed to {new_value}");
                            Console.ReadLine();
                            item.Value.PageSize = new_value;
                            break;
                        }
                    }
                    break;
                case 's':
                    foreach (KeyValuePair<int, Book> item in Db)
                    {
                        if (item.Key == id)
                        {
                            Console.WriteLine($"{item.Value.InStock} book has been changed to {new_value}");
                            Console.ReadLine();
                            item.Value.InStock = new_value;
                            break;
                        }
                    }
                    break;
            }
           
        }

        public static void ChangeInfo(int id, double new_price) // Each Field need his own change method
        {
            foreach (KeyValuePair<int, Book> item in Db)
            {
                if (item.Key == id)
                {
                    Console.WriteLine($"{item.Value.Price} book has been changed to {new_price}");
                    Console.ReadLine();
                    item.Value.Price=new_price;
                    break;
                }
            }
        }

      

        public static void DeleteProduct(int id)
        {
            Db.Remove(id);
            Console.WriteLine("Product Deleted!");
            Console.ReadLine();
        }


    }
}
