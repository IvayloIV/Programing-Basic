using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', n * 2 - 1));
            Console.Write("/|\\");
            Console.WriteLine(new string('.', n * 2 - 1));

            Console.Write(new string('.', n * 2 - 1));
            Console.Write("\\|/");
            Console.WriteLine(new string('.', n * 2 - 1));

            var poits = n * 2 - 1;
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write(new string('.', poits));
                Console.Write('*');
                Console.Write(new string('-', i));
                Console.Write('*');
                Console.Write(new string('-', i));
                Console.Write('*');
                Console.WriteLine(new string('.', poits));
                poits--;
            }

            Console.WriteLine(new string('*', 4 * n + 1));

            for (int i = 0; i < 4 * n + 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
