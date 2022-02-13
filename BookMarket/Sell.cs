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
        

        public double Income
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
                    return 0;
                }

            }
            set
            {
                //Sell();
                _income += value;
            }
        }

    }

    
}
