using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04___Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var under10 = 0;
            var under20 = 0;
            var under30 = 0;
            var under40 = 0;
            var under50 = 0;
            var invalidNum = 0;

            var specilaNum = 0D;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num >= 0 && num <= 9)
                {
                    specilaNum += (num * 0.20);
                    under10++;
                }
                else if (num >= 10 && num <= 19)
                {
                    specilaNum += (num * 0.30);
                    under20++;
                }
                else if (num >= 20 && num <= 29)
                {
                    specilaNum += (num * 0.40);
                    under30++;
                }
                else if (num >= 30 && num <= 39)
                {
                    specilaNum += 50;
                    under40++;
                }
                else if (num >= 40 && num <= 50)
                {
                    specilaNum += 100;
                    under50++;
                }
                else
                {
                    specilaNum /= 2;
                    invalidNum++;
                }
            }
            Console.WriteLine($"{specilaNum:f2}");
            Console.WriteLine($"From 0 to 9: {((double)under10 / n * 100D):f2}%");
            Console.WriteLine($"From 10 to 19: {((double)under20 / n * 100D):f2}%");
            Console.WriteLine($"From 20 to 29: {((double)under30 / n * 100D):f2}%");
            Console.WriteLine($"From 30 to 39: {((double)under40 / n * 100D):f2}%");
            Console.WriteLine($"From 40 to 50: {((double)under50 / n * 100D):f2}%");
            Console.WriteLine($"Invalid numbers: {((double)invalidNum / n * 100D):f2}%");
        }
    }
}
