using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Корона
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("@");
            Console.Write(new string(' ', n - 2));
            Console.Write("@");
            Console.Write(new string(' ', n - 2));
            Console.WriteLine("@");

            var middlePoints = 1;
            for (int i = 0; i < n / 2 + 1; i++)
            {
                if (i == 0)
                {
                    Console.Write("**");
                    Console.Write(new string(' ', (n * 2 - 6) / 2));
                    Console.Write("*");
                    Console.Write(new string(' ', (n * 2 - 6) / 2));
                    Console.WriteLine("**");
                }
                else if (i == n / 2)
                {
                    Console.Write("*");
                    Console.Write(new string('.', i));
                    Console.Write("*");
                    Console.Write(new string('*', (n * 2 - 5 - i * 2) / 2));
                    Console.Write(".");
                    Console.Write(new string('*', (n * 2 - 5 - i * 2) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', i));
                    Console.WriteLine("*");
                }
                else if (i == n / 2 - 1)
                {
                    Console.Write("*");
                    Console.Write(new string('.', i));
                    Console.Write("*");
                    Console.Write(new string('.', middlePoints));
                    Console.Write("*");
                    Console.Write(new string('.', i));
                    Console.WriteLine("*");
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('.', i));
                    Console.Write("*");
                    Console.Write(new string(' ', ((n * 2 - 1) - 6 - (i * 2) - middlePoints) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', middlePoints));
                    Console.Write("*");
                    Console.Write(new string(' ', ((n * 2 - 1) - 6 - (i * 2) - middlePoints) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', i));
                    Console.WriteLine("*");
                    middlePoints += 2;
                }
            }
            Console.WriteLine(new string('*', 2 * n - 1));
            Console.WriteLine(new string('*', 2 * n - 1));
        }
    }
}
