using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());
            var peoples = int.Parse(Console.ReadLine());

            var allGrooze = x * y;
            var wine = 0.4 * (allGrooze / 2.5);

            if (wine < z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(z - wine)} liters wine needed.");
            }
            else
            {
                var t = wine - z;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(t)} liters left -> {Math.Ceiling(t / peoples)} liters per person.");
            }
        }
    }
}
