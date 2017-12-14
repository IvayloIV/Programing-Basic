using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var points = n;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', i));
                Console.Write("*");
                if (i != n - 1)
                {
                    Console.Write(new string('.', points));
                }
                else
                {
                    Console.Write(new string('*', points));
                }
                Console.Write("*");
                if (i != n - 1)
                {
                    Console.Write(new string('.', points));
                }
                else
                {
                    Console.Write(new string('*', points));
                }
                Console.Write("*");
                Console.WriteLine(new string('.', i));
                points--;
            }
            Console.WriteLine(new string('*', 2 * n + 3));

            var downPoints = n - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', downPoints));
                Console.Write('*');
                if (i == 1)
                {
                    Console.Write(new string('*', i));
                }
                else
                {
                    Console.Write(new string('.', i));
                }
                Console.Write('*');
                if (i == 1)
                {
                    Console.Write(new string('*', i));
                }
                else
                {
                    Console.Write(new string('.', i));
                }
                Console.Write('*');
                Console.WriteLine(new string('.', downPoints));
                downPoints--;
            }
        }
    }
}
