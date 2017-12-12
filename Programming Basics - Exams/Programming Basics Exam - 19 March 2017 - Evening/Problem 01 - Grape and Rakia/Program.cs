using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01___Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeGrooze = double.Parse(Console.ReadLine());
            var winKg = double.Parse(Console.ReadLine());
            var brak = double.Parse(Console.ReadLine());

            var grooze = sizeGrooze * winKg;
            var allGrooze = grooze - brak;

            var forRakia = allGrooze * 0.45;
            var litra = forRakia / 7.5;
            var winMoney = litra * 9.80;

            var sells = allGrooze * 0.55;
            var allWins = sells * 1.5;
            Console.WriteLine($"{winMoney:f2}");
            Console.WriteLine($"{allWins:f2}");
        }
    }
}
