using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05___Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write("+");
            Console.Write(new string('~', n - 2));
            Console.Write("+");
            Console.WriteLine(new string('.', n * 2 + 1));

            for (int i = 0; i < n * 2 + 1; i++)
            {
                Console.Write('|');
                Console.Write(new string('.', i));
                Console.Write('\\');
                Console.Write(new string('~', n - 2));
                Console.Write('\\');
                Console.WriteLine(new string('.', (3 * n + 1) - 3 - i - (n - 2)));
            }

            var count = 0;
            for (int i = 0; i < n * 2 + 1; i++)
            {
                Console.Write(new string('.', i));
                Console.Write('\\');
                Console.Write(new string('.', (3 * n + 1) - 3 - i - (n - 2)));
                Console.Write('|');
                Console.Write(new string('~', n - 2));
                Console.WriteLine('|');
                count = i;
            }
            count++;
            Console.Write(new string('.', count));
            Console.Write('+');
            Console.Write(new string('~', n - 2));
            Console.WriteLine('+');
        }
    }
}
