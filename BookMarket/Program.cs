using System;

namespace BookMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.CursorSize = 1;
            Menu menu = new Menu();
            menu.MenuBar();
        }
    }
}
