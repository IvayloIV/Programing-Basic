using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Бонус_точки
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            double bonus = 0;
            if (number <= 100)
            {
                bonus += 5;
            }
            else if (number > 1000)
            {
                bonus = number * 0.10;
            }
            else if (number > 100)
            {
                bonus = number * 0.20;
            }

            var superBonus = 0;

            if (number % 2 == 0)
            {
                superBonus++;
            }
            else if (number % 10 == 5)
            {
                superBonus += 2;
            }

            var sumBonus = superBonus + bonus;
            Console.WriteLine(sumBonus);
            Console.WriteLine(sumBonus + number);
        }
    }
}
