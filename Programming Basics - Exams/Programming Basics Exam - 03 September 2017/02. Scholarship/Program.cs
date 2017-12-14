using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var averageGrade = double.Parse(Console.ReadLine());
            var minMoney = double.Parse(Console.ReadLine());

            var socialMoney = 0D;
            if (money < minMoney && averageGrade >= 4.5)
            {
                socialMoney = 0.35 * minMoney;
            }

            var exellentGrade = 0D;

            if (averageGrade >= 5.50)
            {
                exellentGrade = averageGrade * 25;
            }

            if (socialMoney == 0 && exellentGrade == 0)
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
            else if (socialMoney >= exellentGrade)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialMoney)} BGN");
            }
            else
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(exellentGrade)} BGN");
            }
        }
    }
}
