using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket
{
    internal class Menu
    {
        public int Choice;

        public Menu(int choice)
        {
            Choice = choice;
        }

        public void MenuBar()
        {

            Console.WriteLine("1. Add product to Database.");
            Console.WriteLine("2. Sell products.");
            Console.WriteLine("3. Change product info.");
            Console.WriteLine("4. Delete product.");
            Console.WriteLine("5. Show Income.");
            Console.WriteLine("6. Show Anbar.");
            Console.WriteLine("7.Exit");





            
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
