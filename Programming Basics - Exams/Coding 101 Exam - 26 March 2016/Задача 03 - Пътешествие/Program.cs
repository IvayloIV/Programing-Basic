using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_03___Пътешествие
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            if (money <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    Console.WriteLine($"Camp - {(money * 0.3):f2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Hotel - {(money * 0.7):f2}");
                }
            }
            else if (money <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    Console.WriteLine($"Camp - {(money * 0.4):f2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Hotel - {(money * 0.8):f2}");
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {(money * 0.9):f2}");
            }

        }
    }
}
