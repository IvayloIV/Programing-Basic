using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3___Хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {
            var mount = Console.ReadLine();
            var days = int.Parse(Console.ReadLine());

            double pricePerNightStudio = 0;
            double pricePerNightApart = 0;
            if (mount == "May" || mount == "October")
            {
                pricePerNightStudio = 50;
                pricePerNightApart = 65;
            }
            else if (mount == "June" || mount == "September")
            {
                pricePerNightStudio = 75.20;
                pricePerNightApart = 68.70;
            }
            else if (mount == "July" || mount == "August")
            {
                pricePerNightStudio = 76;
                pricePerNightApart = 77;
            }

            double saleStudio = 0;
            double saleApart = 0;
            if ((mount == "May" || mount == "October") && days > 7 && days <= 14)
            {
                saleStudio = 0.05;
            }
            else if ((mount == "May" || mount == "October") && days > 14)
            {
                saleStudio = 0.3;
            }
            else if ((mount == "June" || mount == "September") && days > 14)
            {
                saleStudio = 0.2;
            }

            if (days > 14)
            {
                saleApart = 0.1;
            }

            if (saleApart == 0)
            {
                var t = pricePerNightApart * days;
                Console.WriteLine($"Apartment: {t:f2} lv.");
            }
            else
            {
                var p = pricePerNightApart * saleApart;
                var r = (pricePerNightApart - p) * days;
                Console.WriteLine($"Apartment: {r:f2} lv.");
            }

            if (saleStudio == 0)
            {
                var t = pricePerNightStudio * days;
                Console.WriteLine($"Studio: {t:f2} lv.");
            }
            else
            {
                var p = pricePerNightStudio * saleStudio;
                var r = (pricePerNightStudio - p) * days;
                Console.WriteLine($"Studio: {r:f2} lv.");
            }
        }
    }
}
