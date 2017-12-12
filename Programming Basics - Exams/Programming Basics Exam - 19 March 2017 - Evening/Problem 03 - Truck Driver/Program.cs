using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03___Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var km = double.Parse(Console.ReadLine());

            if (km <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    var allSum = km * 0.75 * 4;
                    Console.WriteLine($"{(allSum - (allSum * 0.1)):f2}");
                }
                else if (season == "Summer")
                {
                    var allSum = km * 0.9 * 4;
                    Console.WriteLine($"{(allSum - (allSum * 0.1)):f2}");
                }
                else if (season == "Winter")
                {
                    var allSum = km * 1.05 * 4;
                    Console.WriteLine($"{(allSum - (allSum * 0.1)):f2}");
                }
            }
            else if (km <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    var allSum = km * 0.95 * 4;
                    Console.WriteLine($"{(allSum - (allSum * 0.1)):f2}");
                }
                else if (season == "Summer")
                {
                    var allSum = km * 1.1 * 4;
                    Console.WriteLine($"{(allSum - (allSum * 0.1)):f2}");
                }
                else if (season == "Winter")
                {
                    var allSum = km * 1.25 * 4;
                    Console.WriteLine($"{(allSum - (allSum * 0.1)):f2}");
                }
            }
            else if (km <= 20000)
            {
                var allSum = km * 1.45 * 4;
                Console.WriteLine($"{(allSum - (allSum * 0.1)):f2}");
            }
        }
    }
}
