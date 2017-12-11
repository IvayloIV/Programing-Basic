using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03___Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var allMoneys = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            if (allMoneys <= 100)
            {
                Console.WriteLine($"Economy class");
                if (season == "Summer")
                {
                    Console.WriteLine($"Cabrio - {(allMoneys * 0.35):f2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Jeep - {(allMoneys * 0.65):f2}");
                }
            }
            else if (allMoneys <= 500)
            {
                Console.WriteLine($"Compact class");
                if (season == "Summer")
                {
                    Console.WriteLine($"Cabrio - {(allMoneys * 0.45):f2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Jeep - {(allMoneys * 0.8):f2}");
                }

            }
            else if (allMoneys > 500)
            {
                Console.WriteLine($"Luxury class");
                Console.WriteLine($"Jeep - {(allMoneys * 0.9):f2}");
            }
        }
    }
}
