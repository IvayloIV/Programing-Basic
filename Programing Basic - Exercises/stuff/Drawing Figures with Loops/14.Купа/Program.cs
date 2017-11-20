using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._.Купа
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var points = n;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('.', points));
                Console.Write(new string('#', (5 * n) - 2 * points));
                Console.WriteLine(new string('.', points));
                points++;
            }

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.Write(new string('.', points));
                Console.Write("#");
                Console.Write(new string('.', 5 * n - 2 - 2 * points));
                Console.Write("#");
                Console.WriteLine(new string('.', points));
                points++;
            }
            points--;
            Console.Write(new string('.', points));
            Console.Write(new string('#', 5 * n - 2 * points));
            Console.WriteLine(new string('.', points));

            for (int i = 1; i <= n + 2; i++)
            {
                if (i != (n + 2) / 2)
                {
                    Console.Write(new string('.', n * 2 - 2));
                    Console.Write(new string('#', 5 * n - (n * 2 - 2) * 2));
                    Console.WriteLine(new string('.', n * 2 - 2));
                }
                else
                {
                    Console.Write(new string('.', (5 * n - 10) / 2));
                    Console.Write("D^A^N^C^E^");
                    Console.WriteLine(new string('.', (5 * n - 10) / 2));
                }
            }
        }
    }
}
