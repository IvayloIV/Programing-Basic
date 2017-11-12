using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Еднакви_3_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = double.Parse(Console.ReadLine());
            var secoundNum = double.Parse(Console.ReadLine());
            var threeNum = double.Parse(Console.ReadLine());

            if (firstNum == secoundNum && firstNum == threeNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
