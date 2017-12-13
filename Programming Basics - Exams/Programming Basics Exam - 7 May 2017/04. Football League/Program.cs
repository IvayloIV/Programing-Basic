using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacityStadion = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var a = 0;
            var b = 0;
            var v = 0;
            var g = 0;
            for (int i = 0; i < n; i++)
            {
                var sector = Console.ReadLine();
                if (sector == "A")
                {
                    a++;
                }
                else if (sector == "B")
                {
                    b++;
                }
                else if (sector == "V")
                {
                    v++;
                }
                else if (sector == "G")
                {
                    g++;
                }
            }
            Console.WriteLine($"{((double)a / n * 100):f2}%");
            Console.WriteLine($"{((double)b / n * 100):f2}%");
            Console.WriteLine($"{((double)v / n * 100):f2}%");
            Console.WriteLine($"{((double)g / n * 100):f2}%");
            Console.WriteLine($"{((double)n / capacityStadion * 100):f2}%");
        }
    }
}
