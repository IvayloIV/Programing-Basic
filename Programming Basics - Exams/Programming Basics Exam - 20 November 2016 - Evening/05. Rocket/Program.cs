using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var h = n * 3;
            var spase = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', (h - 2 - spase) / 2));
                Console.Write("/");
                Console.Write(new string(' ', spase));
                Console.Write('\\');
                Console.WriteLine(new string('.', (h - 2 - spase) / 2));
                spase += 2;
            }
            Console.Write(new string('.', n / 2));
            Console.Write(new string('*', n * 2));
            Console.WriteLine(new string('.', n / 2));

            for (int i = 0; i < n * 2; i++)
            {
                Console.Write(new string('.', n / 2));
                Console.Write('|');
                Console.Write(new string('\\', n * 2 - 2));
                Console.Write('|');
                Console.WriteLine(new string('.', n / 2));
            }

            var points = n / 2;
            var stars = n * 2 - 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', points));
                Console.Write('/');
                Console.Write(new string('*', stars));
                Console.Write('\\');
                Console.WriteLine(new string('.', points));
                stars += 2;
                points--;
            }
        }
    }
}
