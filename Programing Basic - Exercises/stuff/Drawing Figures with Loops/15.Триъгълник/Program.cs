using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Триъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var average = n / 2 + 1;

            Console.WriteLine(new string('#', 4 * n + 1));

            var shash = n * 2 - 1;
            var white = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i == average)
                {
                    Console.Write(new string('.', i));
                    Console.Write(new string('#', shash));
                    Console.Write(new string(' ', (white - 3) / 2));
                    Console.Write("(@)");
                    Console.Write(new string(' ', (white - 3) / 2));
                    Console.Write(new string('#', shash));
                    Console.WriteLine(new string('.', i));
                }
                else
                {
                    Console.Write(new string('.', i));
                    Console.Write(new string('#', shash));
                    Console.Write(new string(' ', white));
                    Console.Write(new string('#', shash));
                    Console.WriteLine(new string('.', i));
                }
                white += 2;
                shash -= 2;
            }

            var points2 = n + 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', points2));
                Console.Write(new string('#', 4 * n + 1 - points2 * 2));
                Console.WriteLine(new string('.', points2));
                points2++;
            }
        }
    }
}
