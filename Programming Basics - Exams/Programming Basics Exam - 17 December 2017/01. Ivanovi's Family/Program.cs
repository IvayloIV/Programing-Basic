using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Ivanovi_s_Family
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var priceFirst = double.Parse(Console.ReadLine());
            var priceSecound = double.Parse(Console.ReadLine());
            var priceThree = double.Parse(Console.ReadLine());

            var all = priceFirst + priceSecound + priceThree;
            var allBudjet = (budjet - all);
            allBudjet = allBudjet - (allBudjet * 0.1);
            Console.WriteLine($"{allBudjet:f2}");
        }
    }
}
