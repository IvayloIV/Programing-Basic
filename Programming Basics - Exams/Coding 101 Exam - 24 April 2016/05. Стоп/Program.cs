using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Стоп
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var currentN = n;
            var ser = n * 2 - 1;
            for (int i = 1; i <= n + 2; i++)
            {
                if (i == 1)
                {
                    Console.Write(new string('.', n + 1));
                    Console.Write(new string('_', n * 2 + 1));
                    Console.WriteLine(new string('.', n + 1));
                }
                else if (i == n + 2)
                {
                    Console.Write("//");
                    Console.Write(new string('_', n * 2 - 3));
                    Console.Write("STOP!");
                    Console.Write(new string('_', n * 2 - 3));
                    Console.WriteLine(@"\\");
                    
                }
                else
                {
                    Console.Write(new string('.', currentN));
                    Console.Write("//");
                    Console.Write(new string('_', ser));
                    Console.Write(@"\\");
                    Console.WriteLine(new string('.', currentN));
                    ser += 2;
                    currentN--;
                }
            }

            var t = n * 4 - 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(@"\\");
                Console.Write(new string('_', t));
                Console.Write("//");
                Console.WriteLine(new string('.', i));
                t -= 2;
            }
        }
    }
}
