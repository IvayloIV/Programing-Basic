using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            var kg = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var allKm = int.Parse(Console.ReadLine());

            var price = 0D;

            if (kg < 1)
            {
                price = 0.03;
            }
            else if (kg >= 1 && kg <= 10)
            {
                price = 0.05;
            }
            else if (kg >= 11 && kg <= 40)
            {
                price = 0.1;
            }
            else if (kg >= 41 && kg <= 90)
            {
                price = 0.15;
            }
            else if (kg >= 91 && kg <= 150)
            {
                price = 0.20;
            }

            if (type == "standard")
            {
                var sum = price * allKm;
                Console.WriteLine($"The delivery of your shipment with weight of {kg:f3} kg. would cost {sum:f2} lv.");
            }
            else if (type == "express")
            {
                var sum = price * allKm;
                var prozent = 0D;

                if (kg < 1)
                {
                    prozent = 0.8;
                }
                else if (kg >= 1 && kg <= 10)
                {
                    prozent = 0.4;
                }
                else if (kg >= 11 && kg <= 40)
                {
                    prozent = 0.05;
                }
                else if (kg >= 41 && kg <= 90)
                {
                    prozent = 0.02;
                }
                else if (kg >= 91 && kg <= 150)
                {
                    prozent = 0.01;
                }
                var first = prozent * price;
                var secound = kg * first;
                var win = allKm * secound;
                var allSum = sum + win;
                Console.WriteLine($"The delivery of your shipment with weight of {kg:f3} kg. would cost {allSum:f2} lv.");
            }
        }
    }
}
