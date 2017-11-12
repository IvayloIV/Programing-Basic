using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var gore = (x < h * 2) && (x > h) && (y < h * 4);
            var doli = (x < h * 3) && (x > 0) && (y < h) && (y > 0);
            var goreborderr = (y >= h) && (y <= h * 4) && ((x == h) || (x == h * 2));
            var goreborder = (x >= h) && (x <= h * 2) && (y == h * 4);
            var goreborderrr = ((x == h) || (x == h * 2)) && (y == h);
            var doliBorderr = (y <= h) && (y >= 0) && ((x == 0) || (x == h * 3));
            var doliBorder = (x <= h * 3) && (x >= 0) && (y == 0);
            var doliBorderrr = (((x <= h * 3) && (x >= h * 2)) || ((x >= 0) && (x <= h))) && (y == h);


            if (doliBorder || goreborderr || goreborder || goreborderrr || doliBorderr || doliBorderrr)
            {
                Console.WriteLine("border");
            }
            else if (gore || doli)
            {
                Console.WriteLine("inside");
            }
            else if (!gore || !doli)
            {
                Console.WriteLine("outside");
          }
        }
    }
}
