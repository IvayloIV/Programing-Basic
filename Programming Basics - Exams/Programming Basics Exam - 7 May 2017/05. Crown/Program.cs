using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write('@');
            Console.Write(new string(' ', n - 2));
            Console.Write('@');
            Console.Write(new string(' ', n - 2));
            Console.WriteLine('@');

            var middlePoints = 1;
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.Write('*');
                Console.Write(new string('.', i));
                Console.Write('*');
                if (i == 0)
                {
                    Console.Write(new string(' ', ((2 * n - 1) - 2 * i - 5) / 2));
                    Console.Write('*');
                    Console.Write(new string(' ', ((2 * n - 1) - 2 * i - 5) / 2));
                }
                else if (i == n / 2 - 1)
                {
                    Console.Write(new string('.', (2 * n - 1) - 4 - i * 2));
                }
                else if (i == n / 2)
                {
                    Console.Write(new string('*', ((2 * n - 1) - 2 * i - 4) / 2));
                    Console.Write('.');
                    Console.Write(new string('*', ((2 * n - 1) - 2 * i - 4) / 2));
                }
                else
                {
                    Console.Write(new string(' ', ((2 * n - 1) - 2 * i - 6 - middlePoints) / 2));
                    Console.Write('*');
                    Console.Write(new string('.', middlePoints));
                    Console.Write('*');
                    Console.Write(new string(' ', ((2 * n - 1) - 2 * i - 6 - middlePoints) / 2));
                    middlePoints += 2;
                }
                Console.Write('*');
                Console.Write(new string('.', i));
                Console.WriteLine('*');
            }
            Console.WriteLine(new string('*', n * 2 - 1));
            Console.WriteLine(new string('*', n * 2 - 1));
        }
    }
}
