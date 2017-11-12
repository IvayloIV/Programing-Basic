using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Конвертор_за_мерни_единици
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());

            var first = Console.ReadLine();
            double firstNum = 0.0;
            if (first == "mm")
            {
                firstNum = 1000;
            }
            else if (first == "cm")
            {
                firstNum = 100;
            }
            else if (first == "mi")
            {
                firstNum = 0.000621371192;
            }
            else if (first == "in")
            {
                firstNum = 39.3700787;
            }
            else if (first == "km")
            {
                firstNum = 0.001;
            }
            else if (first == "ft")
            {
                firstNum = 3.2808399;
            }
            else if (first == "yd")
            {
                firstNum = 1.0936133;
            }
            else if (first == "m")
            {
                firstNum = 1;
            }


            var secound = Console.ReadLine();
            var secoundNum = 0.0;
            if (secound == "mm")
            {
                secoundNum = 1000;
            }
            else if (secound == "cm")
            {
                secoundNum = 100;
            }
            else if (secound == "mi")
            {
                secoundNum = 0.000621371192;
            }
            else if (secound == "in")
            {
                secoundNum = 39.3700787;
            }
            else if (secound == "km")
            {
                secoundNum = 0.001;
            }
            else if (secound == "ft")
            {
                secoundNum = 3.2808399;
            }
            else if (secound == "yd")
            {
                secoundNum = 1.0936133;
            }
            else if (secound == "m")
            {
                secoundNum = 1;
            }


            Console.WriteLine($"{(number / firstNum * secoundNum):f8}");
        }
    }
}
