using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Еднакви_думи
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstWord = Console.ReadLine().ToLower();
            var secoundWord = Console.ReadLine().ToLower();

            if (firstWord == secoundWord)
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
