using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var rows = double.Parse(Console.ReadLine());
            var columns = double.Parse(Console.ReadLine());

            if (type == "Premiere")
            {
                var sum = rows * columns * 12.0;
                Console.WriteLine($"{sum:f2}");
            }
            else if (type == "Normal")
            {
                var sum = rows * columns * 7.5;
                Console.WriteLine($"{sum:f2}");
            }
            else if (type == "Discount")
            {
                var sum = rows * columns * 5.0;
                Console.WriteLine($"{sum:f2}");
            }
        }
    }
}
