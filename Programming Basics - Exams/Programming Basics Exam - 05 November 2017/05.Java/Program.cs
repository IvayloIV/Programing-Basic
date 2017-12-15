using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Java
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n));
                Console.WriteLine("~ ~ ~");
            }
            Console.WriteLine(new string('=', n * 3  + 5));
            var t = (n - 2) / 2 + 1;
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('|');
                if (i == t - 1)
                {
                    Console.Write(new string('~', n));
                    Console.Write("JAVA");
                    Console.Write(new string('~', n));
                }
                else
                {
                    Console.Write(new string('~', n * 2 + 4));
                }
                Console.Write('|');
                Console.Write(new string(' ', n - 1));
                Console.WriteLine("|");
            }
            Console.WriteLine(new string('=', n * 3 + 5));

            var p = n * 2 + 4;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write('\\');
                Console.Write(new string('@', p));
                Console.WriteLine('/');
                p -= 2;
            }
            var k = n * 2 + 6;
            Console.WriteLine(new string('=', k));
        }
    }
}
