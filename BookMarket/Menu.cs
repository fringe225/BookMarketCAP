using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket
{
    internal class Menu
    {
        

       

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
                Console.WriteLine("7.Exit");

                int.TryParse(Console.ReadLine(), out int choice);

                if(choice == 7)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Enter id - ");
                        int.TryParse(Console.ReadLine(), out int id);
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
                        Book book = new Book(id, name, pageSize, price, inStock, genre);
                        DataBase.AddDb(book);
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.Clear();
                        DataBase.ShowAnbar();
                        Console.ReadLine();
                        break;
                        break;
                    case 7:
                        break;
                       
                }


               
            }
           





            
        }


        public void DbChangeMenu()
        {
            Console.WriteLine("1. Change Name.");
            Console.WriteLine("2. Change Price.");
            Console.WriteLine("3. Change Genre.");
            Console.WriteLine("4. Change PageSize.");
            Console.WriteLine("5. Change InStock.");
        }

   }
}
