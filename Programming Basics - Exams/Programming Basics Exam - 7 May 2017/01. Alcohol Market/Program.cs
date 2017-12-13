using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var yiskiLv = double.Parse(Console.ReadLine());
            var litriBira = double.Parse(Console.ReadLine());
            var litriVino = double.Parse(Console.ReadLine());
            var litriRakia = double.Parse(Console.ReadLine());
            var litriYiski = double.Parse(Console.ReadLine());

            var priceRakia = yiskiLv / 2;
            var priceVino = priceRakia - (priceRakia * 0.4);
            var priceBeer = priceRakia - (priceRakia * 0.8);

            var sumRakia = litriRakia * priceRakia;
            var sumVino = litriVino * priceVino;
            var sumBeer = litriBira * priceBeer;
            var sumWiskey = litriYiski * yiskiLv;
            Console.WriteLine($"{(sumRakia + sumVino + sumBeer + sumWiskey):f2}");
        }
    }
}
