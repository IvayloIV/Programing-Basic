using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            var countHartiq = int.Parse(Console.ReadLine());
            var countRolki = int.Parse(Console.ReadLine());
            var litriLepilo = double.Parse(Console.ReadLine());
            var prozentSale = int.Parse(Console.ReadLine());

            var priceProlki = countHartiq * 5.80;
            var pricePolki = countRolki * 7.20;
            var priceLepilo = litriLepilo * 1.20;

            var sum = priceLepilo + pricePolki + priceProlki;
            var priceWithSale = sum - ((sum * prozentSale) / 100);
            Console.WriteLine($"{priceWithSale:f3}");
        }
    }
}
