using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_04___Деление_без_остатък
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dilever2 = 0;
            var dilever3 = 0;
            var dilever4 = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    dilever2++;
                }
                if (num % 3 == 0)
                {
                    dilever3++;
                }
                if (num % 4 == 0)
                {
                    dilever4++;
                }
            }

            Console.WriteLine($"{(((double)dilever2 / n) * 100):f2}%");
            Console.WriteLine($"{(((double)dilever3 / n) * 100):f2}%");
            Console.WriteLine($"{(((double)dilever4 / n) * 100):f2}%");
        }
    }
}
