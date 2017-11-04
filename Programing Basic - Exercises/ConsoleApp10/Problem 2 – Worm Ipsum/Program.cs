using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Worm_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            var repeated = "";
            var count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                var sum = str.Where(a => a == str[i]).Count();
                if (sum >= 2 && sum > count)
                {
                    repeated = str[i].ToString();
                    count = sum;
                }
            }
            Console.WriteLine(repeated);
        }
    }
}
