using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var sum = int.Parse(Console.ReadLine());

            for (int q = 0; q <= a; q++)
            {
                for (int w = 0; w <= b; w++)
                {
                    for (int e = 0; e <= c; e++)
                    {
                        if (q * 1 + w * 2 + e * 5 == sum)
                        {
                            Console.WriteLine($"{q} * 1 lv. + {w} * 2 lv. + {e} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
