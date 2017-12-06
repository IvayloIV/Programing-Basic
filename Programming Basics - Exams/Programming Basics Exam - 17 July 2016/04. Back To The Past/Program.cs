using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var allMoney = double.Parse(Console.ReadLine());
            var totalYears = int.Parse(Console.ReadLine());

            var years = 18;
            for (int i = 1800; i <= totalYears; i++)
            {
                if (i % 2 == 0)
                {
                    allMoney -= 12000;
                }
                else
                {
                    allMoney -= 12000 + (50 * years);
                }
                years++;
            }
            if (allMoney < 0)
            {
                var money = Math.Abs(allMoney);
                Console.WriteLine($"He will need {money:f2} dollars to survive.");
            }
            else
            {              
                Console.WriteLine($"Yes! He will live a carefree life and will have {allMoney:f2} dollars left.");
            }
        }
    }
}
