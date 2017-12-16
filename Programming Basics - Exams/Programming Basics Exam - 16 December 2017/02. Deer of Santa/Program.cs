using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysKoledaLeft = int.Parse(Console.ReadLine());
            var leftFood = int.Parse(Console.ReadLine());
            var firstDay = double.Parse(Console.ReadLine());
            var secoundDay = double.Parse(Console.ReadLine());
            var threeDay = double.Parse(Console.ReadLine());

            var firstElen = daysKoledaLeft * firstDay;
            var secoundElen = daysKoledaLeft * secoundDay;
            var threeElen = daysKoledaLeft * threeDay;

            var allFood = firstElen + secoundElen + threeElen;
            if (allFood <= leftFood)
            {
                Console.WriteLine($"{Math.Floor(leftFood - allFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(allFood - leftFood)} more kilos of food are needed.");
            }
        }
    }
}
