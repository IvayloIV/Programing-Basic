using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Сумиране_на_секунди
{
    class Program
    {
        static void Main(string[] args)
        {
            var secounds = 0;
            for (int i = 0; i < 3; i++)
            {
                secounds += int.Parse(Console.ReadLine());
            }
            var currentSecounds = secounds % 60;
            var currentMinutes = (secounds / 60) % 60;
            Console.WriteLine($"{currentMinutes}:{currentSecounds:d2}");
        }
    }
}
