using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(@"/");
            Console.Write(new string('^', n / 2));
            Console.Write('\\');
            Console.Write(new string('_', (n * 2) - (n / 2) * 2 - 4));
            Console.Write('/');
            Console.Write(new string('^', n / 2));
            Console.WriteLine('\\');

            var p = (int)Math.Floor((double)n / 2) + 1;
            for (int i = 1; i <= n - 2; i++)
            {
                if (i == n - 2)
                {
                    Console.Write('|');
                    Console.Write(new string(' ', p));
                    Console.Write(new string('_', n * 2 - p * 2 - 2));
                    Console.Write(new string(' ', p));
                    Console.WriteLine('|');
                    continue;
                }
                Console.Write('|');
                Console.Write(new string(' ', n * 2 - 2));
                Console.WriteLine('|');
            }
            Console.Write(@"\");
            Console.Write(new string('_', n / 2));
            Console.Write('/');
            Console.Write(new string(' ', (n * 2) - (n / 2) * 2 - 4));
            Console.Write('\\');
            Console.Write(new string('_', n / 2));
            Console.WriteLine('/');
        }
    }
}
