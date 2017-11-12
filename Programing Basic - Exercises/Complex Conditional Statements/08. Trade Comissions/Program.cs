using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var money = double.Parse(Console.ReadLine());

            var comisionna = -2.3;
            if (town == "sofia")
            {
                if (money >= 0 && money <= 500)
                {
                    comisionna = 0.05;
                }
                else if (money > 500 && money <= 1000)
                {
                    comisionna = 0.07;
                }
                else if (money > 1000 && money <= 10000)
                {
                    comisionna = 0.08;
                }
                else if (money > 10000)
                {
                    comisionna = 0.12;
                }
            }
            else if (town == "varna")
            {
                if (money >= 0 && money <= 500)
                {
                    comisionna = 0.045;
                }
                else if (money > 500 && money <= 1000)
                {
                    comisionna = 0.075;
                }
                else if (money > 1000 && money <= 10000)
                {
                    comisionna = 0.1;
                }
                else if (money > 10000)
                {
                    comisionna = 0.13;
                }
            }
            else if (town == "plovdiv")
            {
                if (money >= 0 && money <= 500)
                {
                    comisionna = 0.055;
                }
                else if (money > 500 && money <= 1000)
                {
                    comisionna = 0.08;
                }
                else if (money > 1000 && money <= 10000)
                {
                    comisionna = 0.12;
                }
                else if (money > 10000)
                {
                    comisionna = 0.145;
                }
            }

            if (comisionna == -2.3)
            {
                Console.WriteLine("error");
            }
            else
            {
                var sum = money * comisionna;
                Console.WriteLine($"{sum:f2}");
            }
        }
    }
}
