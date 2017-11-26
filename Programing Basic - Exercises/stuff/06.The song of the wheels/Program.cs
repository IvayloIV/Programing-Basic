using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var count = 0;
            var specialNum = "";
            var isHere = false;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a * b + c * d == n && a < b && c > d)
                            {
                                isHere = true;
                                count++;
                                if (count == 4)
                                {
                                    specialNum = $"{a}{b}{c}{d}";
                                    Console.Write($"{a}{b}{c}{d} ");
                                }
                                else
                                {
                                    Console.Write($"{a}{b}{c}{d} ");
                                }
                            }
                        }
                    }
                }
            }
            if (isHere)
            {
                Console.WriteLine();
            }

            if (specialNum != "")
            {
                Console.WriteLine("Password: " + specialNum);
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
