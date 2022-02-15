using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket
{
    internal class Sell
    {
        private static double _income=0;
        

        public static double Income
        {
            get 
            {
                Console.WriteLine("Enter password from kassa:");
                string password = Console.ReadLine()??"";
                if (password == "4312")
                {
                    return _income;

                }
                else
                {
                    
                    Console.WriteLine("OGRUUUUUU!!! VOOOOOORRR!!!");
                    Console.ReadLine();
                    return 0;
                }

            }
            set
            {
                //Sell();
                _income += value;
            }
        }

        public static void SellProduct(int id, int count) 
        {
            foreach(var item in DataBase.Db)
            {
                if (item.Key == id)
                {
                    if (item.Value.InStock>= count) // added =
                    {
                        item.Value.InStock -= count;
                        Income = item.Value.Price * count;
                        Console.WriteLine($"{item.Value.Name} book has been sold in {count} size!\n" +
                            $"{item.Value.Name} book InStock - {item.Value.InStock}");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("We don't have enough book to sell! ");
                        Console.ReadLine();
                    }
                   
                }
            }

            
        }

        public static void ShowIncome()
        {
            Console.WriteLine($"{Income} AZN");
        }

    }

    
}
