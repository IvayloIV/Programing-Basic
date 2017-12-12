using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06___Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var specialNum = int.Parse(Console.ReadLine());

            var sum = 0;
            var count = 0;
            for (int q = 1; q <= n; q++)
            {
                for (int w = m; w >= 1; w--)
                {
                    count++;
                    sum += q * 2 + w * 3;
                    if (sum >= specialNum)
                    {
                        Console.WriteLine($"{count} moves");
                        Console.WriteLine($"Score: {sum} >= {specialNum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} moves");
        }
    }
}
