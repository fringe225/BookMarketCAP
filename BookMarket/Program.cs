using System;

namespace BookMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;

            Menu menu = new Menu();
            menu.MenuBar();
        }
    }
}
