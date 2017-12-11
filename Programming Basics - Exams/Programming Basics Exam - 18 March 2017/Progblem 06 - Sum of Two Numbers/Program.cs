using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progblem_06___Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var specialNum = int.Parse(Console.ReadLine());

            var count = 0;
            for (int q = start; q <= end; q++)
            {
                for (int w = start; w <= end; w++)
                {
                    count++;
                    if (q + w == specialNum)
                    {
                        Console.WriteLine($"Combination N:{count} ({q} + {w} = {specialNum})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {specialNum}");
        }
    }
}
