using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lenght = decimal.Parse(Console.ReadLine()) * 100;
            decimal width = decimal.Parse(Console.ReadLine());

            if (width == 0)
            {
                Console.WriteLine($"0.00");
                return;
            }
            if (lenght % width == 0)
            {
                var sum = lenght * width;
                Console.WriteLine($"{sum:f2}");
            }
            else
            {
                var sum = (lenght / width) * 100;
                Console.WriteLine($"{sum:f2}%");
            }
        }
    }
}
