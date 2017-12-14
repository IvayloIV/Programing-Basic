using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Photo_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            var countPhoto = int.Parse(Console.ReadLine());
            var typePicture = Console.ReadLine();
            var preser = Console.ReadLine();

            var price = 0D;
            if (typePicture == "9X13")
            {
                price = countPhoto * 0.16;
                if (countPhoto >= 50)
                {
                    price *= 0.95;
                }
            }
            else if (typePicture == "10X15")
            {
                price = countPhoto * 0.16;
                if (countPhoto >= 80)
                {
                    price *= 0.97;
                }
            }
            else if (typePicture == "13X18")
            {
                price = countPhoto * 0.38;
                if (countPhoto >= 50 && countPhoto <= 100)
                {
                    price *= 0.97;
                }
                else if (countPhoto > 100)
                {
                    price *= 0.95;
                }
            }
            else if (typePicture == "20X30")
            {
                price = countPhoto * 2.90;
                if (countPhoto >= 10 && countPhoto <= 50)
                {
                    price *= 0.93;
                }
                else if (countPhoto > 50)
                {
                    price *= 0.91;
                }
            }

            if (preser == "online")
            {
                price *= 0.98;
            }
            Console.WriteLine($"{price:f2}BGN");
        }
    }
}
