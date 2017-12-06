using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var points = n;
            var p = n * 3;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', points));
                if (i == 0)
                {
                    Console.Write(new string('*', p));
                }
                else
                {
                    Console.Write('*');
                    Console.Write(new string('.', p));
                    Console.Write('*');
                    p += 2;
                }
                Console.WriteLine(new string('.', points));
                points--;
            }
            Console.WriteLine(new string('*', n * 5));
            for (int i = 1; i <= n * 2 + 1; i++)
            {
                Console.Write(new string('.', i));
                Console.Write('*');
                if (i != n * 2 + 1)
                {
                    Console.Write(new string('.', 5 * n - 2 - i * 2));
                }
                else
                {
                    Console.Write(new string('*', 5 * n - 2 - i * 2));
                }
                Console.Write('*');
                Console.WriteLine(new string('.', i));
            }
        }
    }
}
