using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigLetter = char.Parse(Console.ReadLine());
            var smalLetter1 = char.Parse(Console.ReadLine());
            var smalLetter2 = char.Parse(Console.ReadLine());
            var smalLetter3 = char.Parse(Console.ReadLine());
            var num = int.Parse(Console.ReadLine());

            var count = 0;
            for (char q = 'A'; q <= bigLetter; q++)
            {
                for (char w = 'a'; w <= smalLetter1; w++)
                {
                    for (char e = 'a'; e <= smalLetter2; e++)
                    {
                        for (char r = 'a'; r <= smalLetter3; r++)
                        {
                            for (int t = 0; t <= num; t++)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count - 1);
        }
    }
}
