using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var even = new List<double>();
            var odd = new List<double>();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    odd.Add(double.Parse(Console.ReadLine()));
                }
                else
                {
                    even.Add(double.Parse(Console.ReadLine()));
                }
            }

            if (odd.Count != 0)
            {
                Console.WriteLine($"OddSum={odd.Sum()},");
                Console.WriteLine($"OddMin={odd.Min()},");
                Console.WriteLine($"OddMax={odd.Max()},");
            }
            else
            {
                Console.WriteLine($"OddSum=0,");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }

            if (even.Count != 0)
            {
                Console.WriteLine($"EvenSum={even.Sum()},");
                Console.WriteLine($"EvenMin={even.Min()},");
                Console.WriteLine($"EvenMax={even.Max()},");
            }
            else
            {
                Console.WriteLine($"EvenSum=0,");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No,");
            }
        }
    }
}

