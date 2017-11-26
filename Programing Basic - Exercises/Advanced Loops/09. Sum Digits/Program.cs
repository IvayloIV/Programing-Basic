using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();

            var book = new List<int>();

            for (int i = 0; i < n.ToString().Length; i++)
            {
                book.Add(int.Parse(n[i].ToString()));
            }
            Console.WriteLine(book.Sum());
        }
    }
}
