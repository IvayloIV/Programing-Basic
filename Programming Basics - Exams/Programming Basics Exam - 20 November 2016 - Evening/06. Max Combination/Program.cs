using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            var currentIndex = 0;

            for (int q = start; q <= end; q++)
            {
                for (int w = start; w <= end; w++)
                {
                    Console.Write($"<{q}-{w}>");
                    currentIndex++;
                    if (currentIndex == max)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
            }
        }
    }
}
