using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Генератор_на_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            var specialNum = int.Parse(Console.ReadLine());
            var controlNum = int.Parse(Console.ReadLine());

            for (int q = m; q >= 1; q--)
            {
                for (int w = n; w >= 1; w--)
                {
                    for (int e = l; e >= 1; e--)
                    {
                        if (specialNum >= controlNum)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNum}.");
                            return;
                        }

                        if (int.Parse($"{q}{w}{e}") % 3 == 0)
                        {
                            specialNum += 5;
                        }
                        else if (int.Parse($"{q}{w}{e}") % 10 == 5)
                        {
                            specialNum -= 2;
                        }
                        else if (int.Parse($"{q}{w}{e}") % 2 == 0)
                        {
                            specialNum *= 2;
                        }
                    }
                }
            }
            Console.WriteLine($"No! {specialNum} is the last reached special number.");

        }
    }
}
