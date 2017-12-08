using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2___Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededHours = int.Parse(Console.ReadLine());
            var daysInraz = int.Parse(Console.ReadLine());
            var peoples = int.Parse(Console.ReadLine());

            var hoursForWorks = ((double)daysInraz * 0.9) * 8D;
            var outOfWork = peoples * (2 * daysInraz);
            var allHours = hoursForWorks + outOfWork;

            var allhourst = Math.Floor(allHours);
            if (neededHours > allhourst)
            {
                var breaka = neededHours - allhourst;
                Console.WriteLine($"Not enough time!{breaka} hours needed.");
            }
            else
            {
                var breakas = allhourst - neededHours;
                Console.WriteLine($"Yes!{breakas} hours left.");
            }
            //$"Yes!{breaka} hours left."
            //$"Not enough time!{breakas} hours needed."
        }
    }
}
