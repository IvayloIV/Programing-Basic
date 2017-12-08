using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldPeoples = int.Parse(Console.ReadLine());
            var youngPeople = int.Parse(Console.ReadLine());
            var sleepNights = int.Parse(Console.ReadLine());
            var trans = Console.ReadLine();

            double priceOld = 0;
            double priceYound = 0;

            if (trans == "train")
            {
                priceOld = 24.99;
                priceYound = 14.99;
                if (oldPeoples + youngPeople >= 50)
                {
                    priceOld /= 2;
                    priceYound /= 2;
                }
            }
            else if (trans == "bus")
            {
                priceOld = 32.50;
                priceYound = 28.50;
            }
            else if (trans == "boat")
            {
                priceOld = 42.99;
                priceYound = 39.99;
            }
            else if (trans == "airplane")
            {
                priceOld = 70.00;
                priceYound = 50.00;
            }

            var allSumTrans = (oldPeoples * priceOld + priceYound * youngPeople) * 2;
            var hotel = sleepNights * 82.99;
            var komis = (allSumTrans + hotel) * 0.1;
            var allSum = allSumTrans + hotel + komis;
            Console.WriteLine($"{allSum:f2}");
        }
    }
}
