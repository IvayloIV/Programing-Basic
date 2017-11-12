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

            var del2 = 0;
            var del3 = 0;
            var del4 = 0;
            for (int i = 0; i < n; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());

                if (currentNum % 2 == 0)
                {
                    del2++;
                }
                if (currentNum % 3 == 0)
                {
                    del3++;
                }
                if (currentNum % 4 == 0)
                {
                    del4++;
                }
            }

            Console.WriteLine($"{(((double)del2 / n) * 100):f2}%");
            Console.WriteLine($"{(((double)del3 / n) * 100):f2}%");
            Console.WriteLine($"{(((double)del4 / n) * 100):f2}%");
        }
    }
}
