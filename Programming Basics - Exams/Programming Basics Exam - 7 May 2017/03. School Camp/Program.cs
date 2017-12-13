using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var typePeople = Console.ReadLine();
            var countPeople = int.Parse(Console.ReadLine());
            var peoplesSleeps = int.Parse(Console.ReadLine());

            if (season == "Winter")
            {
                if (typePeople == "girls")
                {
                    Console.Write("Gymnastics ");
                }
                else if (typePeople == "boys")
                {
                    Console.Write("Judo ");
                }
                else if (typePeople == "mixed")
                {
                    Console.Write("Ski ");
                }
            }
            else if (season == "Spring")
            {
                if (typePeople == "girls")
                {
                    Console.Write("Athletics ");
                }
                else if (typePeople == "boys")
                {
                    Console.Write("Tennis ");
                }
                else if (typePeople == "mixed")
                {
                    Console.Write("Cycling ");
                }
            }
            else if (season == "Summer")
            {
                if (typePeople == "girls")
                {
                    Console.Write("Volleyball ");
                }
                else if (typePeople == "boys")
                {
                    Console.Write("Football ");
                }
                else if (typePeople == "mixed")
                {
                    Console.Write("Swimming ");
                }
            }

            var currentSum = 0D;
            if (typePeople == "boys" || typePeople == "girls")
            {
                if (season == "Winter")
                {
                    currentSum = countPeople* peoplesSleeps * 9.60;
                }
                else if (season == "Spring")
                {
                    currentSum = countPeople * peoplesSleeps * 7.20;
                }
                else if (season == "Summer")
                {
                    currentSum = countPeople * peoplesSleeps * 15D;
                }
            }
            else if (typePeople == "mixed")
            {
                if (season == "Winter")
                {
                    currentSum = countPeople * peoplesSleeps * 10D;
                }
                else if (season == "Spring")
                {
                    currentSum = countPeople * peoplesSleeps * 9.50;
                }
                else if (season == "Summer")
                {
                    currentSum = countPeople * peoplesSleeps * 20D;
                }
            }

            if (countPeople >= 50)
            {
                currentSum *= 0.5;
            }
            else if (countPeople >= 20)
            {
                currentSum *= 0.85;
            }
            else if (countPeople >= 10)
            {
                currentSum *= 0.95;
            }
            Console.WriteLine($"{currentSum:f2} lv.");
        }
    }
}
