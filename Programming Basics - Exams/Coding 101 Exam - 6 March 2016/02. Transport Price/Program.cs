using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            var day = Console.ReadLine();

            if (km < 20)
            {
                if (day == "day")
                {
                    Console.WriteLine(0.70 + 0.79 * km);
                }
                else if (day == "night")
                {
                    Console.WriteLine(0.70 + 0.90 * km);
                }
            }
            else if (km >= 100)
            {
                Console.WriteLine(0.06 * km);
            }
            else
            {
                Console.WriteLine(0.09 * km);
            }
        }
    }
}
