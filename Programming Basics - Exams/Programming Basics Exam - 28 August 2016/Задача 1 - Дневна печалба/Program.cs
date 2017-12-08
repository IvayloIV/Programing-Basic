using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_01___Дневна_печалба
{
    class Program
    {
        static void Main(string[] args)
        {
            var worksDays = int.Parse(Console.ReadLine());
            var winMoney = double.Parse(Console.ReadLine());
            var dolars = double.Parse(Console.ReadLine());

            var moundOne = worksDays * winMoney;
            var yearWin = moundOne * 12 + moundOne * 2.5;
            var danuk = yearWin * 0.25;
            var clearWin = (yearWin - danuk) * dolars;
            var winPerDay = clearWin / 365;
            Console.WriteLine($"{winPerDay:f2}");
        }
    }
}
