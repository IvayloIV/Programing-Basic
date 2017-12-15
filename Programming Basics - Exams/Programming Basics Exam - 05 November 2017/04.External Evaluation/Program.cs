using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var under22 = 0D;
            var under40 = 0D;
            var under58 = 0D;
            var under76 = 0D;
            var under100 = 0D;
            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());

                if (num >= 0 && num < 22.5)
                {
                    under22++;
                }
                else if (num >= 22.5 && num < 40.5)
                {
                    under40++;
                }
                else if (num >= 40.5 && num < 58.5)
                {
                    under58++;
                }
                else if (num >= 58.5 && num < 76.5)
                {
                    under76++;
                }
                else if (num >= 76.5 && num <= 100)
                {
                    under100++;
                }
            }
            Console.WriteLine($"{((under22 / n) * 100):f2}% poor marks");
            Console.WriteLine($"{((under40 / n) * 100):f2}% satisfactory marks");
            Console.WriteLine($"{((under58 / n) * 100):f2}% good marks");
            Console.WriteLine($"{((under76 / n) * 100):f2}% very good marks");
            Console.WriteLine($"{((under100 / n) * 100):f2}% excellent marks");
        }
    }
}
