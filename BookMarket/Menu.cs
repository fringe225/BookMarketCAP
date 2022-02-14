using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket
{
    internal class Menu
    {

        public int Id;
       

        public void MenuBar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add product to Database.");
                Console.WriteLine("2. Sell products.");
                Console.WriteLine("3. Change product info.");
                Console.WriteLine("4. Delete product.");
                Console.WriteLine("5. Show Income.");  // By Get method if password true
                Console.WriteLine("6. Show Anbar.");
                Console.WriteLine("7. Exit");

                int.TryParse(Console.ReadLine(), out int choice);

                if(choice == 7)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Id =EnterId();
                        Console.Write("Enter Book name - ");
                        string name = Console.ReadLine()??"";
                        Console.Write("Enter Page size - ");
                        int.TryParse(Console.ReadLine(), out int pageSize);
                        Console.Write("Enter Book price - ");
                        double.TryParse(Console.ReadLine(), out double price);
                        Console.Write("Enter Stock size - ");
                        int.TryParse(Console.ReadLine(), out int inStock);
                        Console.Write("Enter Book Genre - ");
                        string genre = Console.ReadLine() ?? "";
                        Book book = new Book(Id, name, pageSize, price, inStock, genre);
                        DataBase.AddDb(book);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        int id = EnterId();
                        Console.Write("Enter book count - ");
                        int.TryParse(Console.ReadLine(), out int count);
                        Sell.SellProduct(id, count);
                        break;
                    case 3:
                        Console.Clear();
                        Id = EnterId();
                        Console.Clear();
                        DbChangeMenu(Id);
                        break;
                    case 4:
                        Console.Clear();
                        Id = EnterId();
                        DataBase.DeleteProduct(Id);
                        
                        break;
                    case 5:
                        Console.Clear();
                        Sell.ShowIncome();
                        Console.ReadLine();
                        break;


                    case 6:
                        Console.Clear();
                        DataBase.ShowAnbar();
                        Console.ReadLine();
                        break;
                        
                    case 7:
                        break;
                       
                }


               
            }
           

        }


        public void DbChangeMenu(int id)
        {

            foreach (var item in DataBase.Db)
            {
                if (item.Key == id)
                {
                    Console.Write($"Id.{item.Key}\nProduct Name: {item.Value.Name}\nProduct Price: {item.Value.Price}\n" +
                    $"PageSize: {item.Value.PageSize}\nProduct size in Stock: {item.Value.InStock}\nBook Genre: {item.Value.Genre}\n");
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("1. Change Name.");
            Console.WriteLine("2. Change Price.");
            Console.WriteLine("3. Change Genre.");
            Console.WriteLine("4. Change PageSize.");
            Console.WriteLine("5. Change InStock.");
            string value;
            int value_integer;
            double price;

            int.TryParse(Console.ReadLine(), out int choice);

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Enter new name - ");
                    value = Console.ReadLine()??" ";
                    DataBase.ChangeInfo(id, value, 'n');
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Enter new price - ");
                    double.TryParse(Console.ReadLine(), out price);
                    DataBase.ChangeInfo(id, price);
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Enter new Genre - ");
                    value = Console.ReadLine() ?? "";
                    DataBase.ChangeInfo(id, value, 'g');
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Enter new Page Size - ");
                    int.TryParse(Console.ReadLine(),out value_integer);
                    DataBase.ChangeInfo(id, value_integer, 'p');
                    break;
                case 5:
                    Console.Clear();
                    Console.Write("Enter new Stock - ");
                    int.TryParse(Console.ReadLine(), out value_integer);
                    DataBase.ChangeInfo(id, value_integer, 's');
                    break;

            }
        }


        public int EnterId()
        {
            Console.Write("Enter id - ");
            int.TryParse(Console.ReadLine(), out int id);
            return id;
        }

       


    }
}
