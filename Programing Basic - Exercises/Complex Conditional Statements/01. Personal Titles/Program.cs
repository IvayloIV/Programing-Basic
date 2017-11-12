using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var titles = Console.ReadLine();

            if (age < 16)
            {
                if (titles == "m")
                {
                    Console.WriteLine("Master");
                }
                else if (titles == "f")
                {
                    Console.WriteLine("Miss");
                }
            }
            else if (age >= 16)
            {
                if (titles == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else if (titles == "f")
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
