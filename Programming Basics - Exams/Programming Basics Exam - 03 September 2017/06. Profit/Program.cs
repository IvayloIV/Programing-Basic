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
            var lv1 = int.Parse(Console.ReadLine());
            var lv2 = int.Parse(Console.ReadLine());
            var lv5 = int.Parse(Console.ReadLine());
            var sum = int.Parse(Console.ReadLine());

            for (int q = 0; q <= lv1; q++)
            {
                for (int w = 0; w <= lv2; w++)
                {
                    for (int e = 0; e <= lv5; e++)
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
