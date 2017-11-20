using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var underScope = (int)Math.Ceiling((double)n / 2) - 1;
            var middleUnder = 0;
            if (n % 2 == 0)
            {
                middleUnder = 2;
            }
            else
            {
                middleUnder = 1;
            }

            for (int i = 0; i < (int)Math.Ceiling((double)n / 2); i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('-', underScope));
                    Console.Write(new string('*', n - underScope * 2));
                    Console.WriteLine(new string('-', underScope));
                }
                else
                {
                    Console.Write(new string('-', underScope));
                    Console.Write("*");
                    Console.Write(new string('-', middleUnder));
                    Console.Write("*");
                    Console.WriteLine(new string('-', underScope));
                    middleUnder += 2;
                }
                underScope--;
            }

            var endType = 1;
            var k = (int)Math.Ceiling((double)n / 2) - 1;
            for (int i = 1; i <= k; i++)
            {
                if (i == k)
                {
                    Console.Write(new string('-', endType));
                    Console.Write(new string('*', n - (endType * 2)));
                    Console.Write(new string('-', endType));
                }
                else
                {
                    Console.Write(new string('-', endType));
                    Console.Write("*");
                    Console.Write(new string('-', n - (endType * 2) - 2));
                    Console.Write("*");
                    Console.Write(new string('-', endType));
                }
                Console.WriteLine();
                endType++;
            }
        }
    }
}
