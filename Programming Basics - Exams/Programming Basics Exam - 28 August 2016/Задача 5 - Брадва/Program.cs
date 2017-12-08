using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5___Брадва
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', n * 3));
                Console.Write('*');
                Console.Write(new string('-', i));
                Console.Write('*');
                Console.WriteLine(new string('-', (5 * n) - 2 - i - (n * 3)));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('*', n * 3));
                Console.Write('*');
                Console.Write(new string('-', (n * 5) - (n * 3) - 2 - (n - 1)));
                Console.Write('*');
                Console.WriteLine(new string('-', n - 1));
            }

            var t = n * 3;
            var k = n - 1;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('-', t));
                Console.Write('*');
                if (i != n / 2)
                {
                    Console.Write(new string('-', k));
                }
                else
                {
                    Console.Write(new string('*', k));
                }
                Console.Write('*');
                Console.WriteLine(new string('-', n * 5 - t - k - 2));
                k += 2;
                t--;
            }
        }
    }
}
