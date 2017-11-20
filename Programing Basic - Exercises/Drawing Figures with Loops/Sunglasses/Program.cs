using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            FiratAndLast(n);
            for (int i = 1; i <= n - 2; i++)
            {
                Inside(n);
                for (int p = 1; p <= n; p++)
                {
                    if (i == Math.Ceiling((double)n / 2) - 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Inside(n);
                Console.WriteLine();
            }
            FiratAndLast(n);
        }

        private static void Inside(int n)
        {
            Console.Write("*");
            for (int t = 1; t <= n * 2 - 2; t++)
            {
                Console.Write("/");
            }
            Console.Write("*");
        }

        private static void FiratAndLast(int n)
        {
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));
        }
    }
}
