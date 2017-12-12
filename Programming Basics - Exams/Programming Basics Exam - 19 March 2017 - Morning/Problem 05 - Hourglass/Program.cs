using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05___Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', n * 2 + 1));

            for (int i = 1; i <= n; i++)
            {
                if (i != n)
                {
                    Console.Write(new string('.', i));
                    Console.Write('*');
                    if (i == 1)
                    {
                        Console.Write(new string(' ', n * 2 + 1 - (2 * i) - 2));
                    }
                    else
                    {
                        Console.Write(new string('@', n * 2 + 1 - (2 * i) - 2));
                    }
                    Console.Write('*');
                    Console.WriteLine(new string('.', i));
                }
                else
                {
                    Console.Write(new string('.', i));
                    Console.Write(new string('*', n * 2 + 1 - (2 * i)));
                    Console.WriteLine(new string('.', i));
                }
            }

            var points = n - 1;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', points));
                Console.Write('*');
                if (i != n - 2)
                {
                    Console.Write(new string(' ', i));
                    Console.Write('@');
                    Console.Write(new string(' ', i));
                }
                else
                {
                    Console.Write(new string('@', n * 2 - 3));
                }
                Console.Write('*');
                Console.WriteLine(new string('.', points));
                points--;
            }
            Console.WriteLine(new string('*', n * 2 + 1));
        }
    }
}
