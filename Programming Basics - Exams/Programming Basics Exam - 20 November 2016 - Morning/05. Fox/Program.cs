using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var p = n * 2 - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*', i));
                Console.Write('\\');
                Console.Write(new string('-', p));
                Console.Write('/');
                Console.WriteLine(new string('*', i));
                p -= 2;
            }

            var u = n;

            for (int i = 1; i <= n / 3; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', ((2 * n + 3) - 4 - u) / 2));
                Console.Write('\\');
                Console.Write(new string('*', u));
                Console.Write('/');
                Console.Write(new string('*', ((2 * n + 3) - 4 - u) / 2));
                Console.WriteLine('|');
                u -= 2;
            }

            var x = n * 2 - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', i));
                Console.Write('\\');
                Console.Write(new string('*', x));
                Console.Write('/');
                Console.WriteLine(new string('-', i));
                x -= 2;
            }
        }
    }
}

