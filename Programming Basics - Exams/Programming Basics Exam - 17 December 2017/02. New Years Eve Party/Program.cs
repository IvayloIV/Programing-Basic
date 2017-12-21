using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.New_Years_Eve_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var peoples = int.Parse(Console.ReadLine());
            var alMoney = int.Parse(Console.ReadLine());

            var price = peoples * 20;
            if (price > alMoney)
            {
                var t = price - alMoney;
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {t} lv more.");
            }
            else
            {
                var all = alMoney - price;
                var priceFoerverki = all * 0.4;
                var dareniq = all - priceFoerverki;
                Console.WriteLine($"Yes! {Math.Round(priceFoerverki)} lv are for fireworks and {Math.Round(dareniq)} lv are for donation. ");
            }
        }
    }
}
