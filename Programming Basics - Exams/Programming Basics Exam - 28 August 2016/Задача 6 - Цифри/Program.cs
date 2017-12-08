using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6___Цифри
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();

            var firstNum = int.Parse(num[0].ToString());
            var secoundNum = int.Parse(num[1].ToString());
            var thredNum = int.Parse(num[2].ToString());

            var currentNum = int.Parse(num);
            for (int i = 0; i < firstNum + secoundNum; i++)
            {
                for (int t = 0; t < firstNum + thredNum; t++)
                {
                    if (currentNum % 5 == 0)
                    {
                        currentNum -= firstNum;
                    }
                    else if (currentNum % 3 == 0)
                    {
                        currentNum -= secoundNum;
                    }
                    else
                    {
                        currentNum += thredNum;
                    }
                    Console.Write($"{currentNum} ");
                }
                Console.WriteLine();
            }
        }
    }
}
