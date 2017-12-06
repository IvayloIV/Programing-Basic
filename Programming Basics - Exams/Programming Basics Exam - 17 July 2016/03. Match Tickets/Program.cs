using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var allMoney = double.Parse(Console.ReadLine());
            var group = Console.ReadLine();
            var peoples = double.Parse(Console.ReadLine());

            double transport = 0;

            if (peoples >= 1 && peoples <= 4)
            {
                transport = allMoney - (allMoney * 0.75);
            }
            else if (peoples >= 5 && peoples <= 9)
            {
                transport = allMoney - (allMoney * 0.6);
            }
            else if (peoples >= 10 && peoples <= 24)
            {
                transport = allMoney - (allMoney * 0.5);
            }
            else if (peoples >= 25 && peoples <= 49)
            {
                transport = allMoney - (allMoney * 0.4);
            }
            else if (peoples >= 50)
            {
                transport = allMoney - (allMoney * 0.25);
            }

            double priceTicket = 0;

            if (group == "VIP")
            {
                priceTicket = 499.99;
            }
            else if (group == "Normal")
            {
                priceTicket = 249.99;
            }

            var allPoer = priceTicket * peoples;

            if (allPoer > transport)
            {
                var currentSum = allPoer - transport;
                Console.WriteLine($"Not enough money! You need {currentSum:f2} leva.");
            }
            else
            {
                var currentSum2 = transport - allPoer;
                Console.WriteLine($"Yes! You have {currentSum2:f2} leva left.");
            }
        }
    }
}
