using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03___Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            if (money <= 1000)
            {
                if (season == "Summer")
                {
                    Console.WriteLine($"Alaska - Camp - {(money * 0.65):f2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Morocco - Camp - {(money * 0.45):f2}");
                }
            }
            else if (money <= 3000)
            {
                if (season == "Summer")
                {
                    Console.WriteLine($"Alaska - Hut - {(money * 0.8):f2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Morocco - Hut - {(money * 0.6):f2}");
                }
            }
            else if (money > 3000)
            {
                if (season == "Summer")
                {
                    Console.WriteLine($"Alaska - Hotel - {(money * 0.9):f2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Morocco - Hotel - {(money * 0.9):f2}");
                }
            }
        }
    }
}
