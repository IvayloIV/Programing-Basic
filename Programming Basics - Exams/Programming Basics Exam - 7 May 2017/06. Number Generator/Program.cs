using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_Generator
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
                        var currentNum = int.Parse($"{q}{w}{e}");
                        if (currentNum % 3 == 0)
                        {
                            specialNum += 5;
                        }
                        else if (currentNum % 10 == 5)
                        {
                            specialNum -= 2;
                        }
                        else if (currentNum % 2 == 0)
                        {
                            specialNum *= 2;
                        }
                        if (specialNum >= controlNum)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNum}.");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine($"No! {specialNum} is the last reached special number.");
        }
    }
}
