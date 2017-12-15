using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var points = (3 * n - 1) / 2;

            Console.Write(new string('.', points));
            Console.Write('x');
            Console.WriteLine(new string('.', points));

            Console.Write(new string('.', points - 1));
            Console.Write("/x\\");
            Console.WriteLine(new string('.', points - 1));


            Console.Write(new string('.', points - 1));
            Console.Write("x|x");
            Console.WriteLine(new string('.', points - 1));

            var x = n;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', ((3 * n) - x * 2 - 1) / 2));
                Console.Write(new string('x', x));
                Console.Write('|');
                Console.Write(new string('x', x));
                Console.WriteLine(new string('.', ((3 * n) - x * 2 - 1) / 2));
                if (i < n / 2)
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }

            var points2 = (3 * n - 3) / 2;
            Console.Write(new string('.', points2));
            Console.Write("/x\\");
            Console.WriteLine(new string('.', points2));

            Console.Write(new string('.', points2));
            Console.Write("\\x/");
            Console.WriteLine(new string('.', points2));

            x = n;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', ((3 * n) - x * 2 - 1) / 2));
                Console.Write(new string('x', x));
                Console.Write('|');
                Console.Write(new string('x', x));
                Console.WriteLine(new string('.', ((3 * n) - x * 2 - 1) / 2));
                if (i < n / 2)
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }

            Console.Write(new string('.', points - 1));
            Console.Write("x|x");
            Console.WriteLine(new string('.', points - 1));

            Console.Write(new string('.', points - 1));
            Console.Write("\\x/");
            Console.WriteLine(new string('.', points - 1));

            Console.Write(new string('.', points));
            Console.Write('x');
            Console.WriteLine(new string('.', points));
        }
    }
}
