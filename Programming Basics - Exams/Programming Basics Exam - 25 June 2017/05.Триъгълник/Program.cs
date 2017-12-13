using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Триъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('#', 4 * n + 1));

            var white = 1;
            var t = 2 * n - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('#', t));
                if (i != n / 2 + 1)
                {
                    Console.Write(new string(' ', white));
                }
                else
                {
                    Console.Write(new string(' ', n / 2 - 1));
                    Console.Write("(@)");
                    Console.Write(new string(' ', n / 2 - 1));
                }
                Console.Write(new string('#', t));
                Console.WriteLine(new string('.', i));
                white += 2;
                t -= 2;
            }

            var downPoint = n + 1;
            var downHash = n * 2 - 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', downPoint));
                Console.Write(new string('#', downHash));
                Console.WriteLine(new string('.', downPoint));
                downPoint++;
                downHash -= 2;
            }
        }
    }
}
