using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();

            for (int q = 1; q <= int.Parse(num[2].ToString()); q++)
            {
                for (int w = 1; w <= int.Parse(num[1].ToString()); w++)
                {
                    for (int e = 1; e <= int.Parse(num[0].ToString()); e++)
                    {
                        Console.WriteLine($"{q} * {w} * {e} = {q * w * e};");
                    }
                }
            }
        }
    }
}
