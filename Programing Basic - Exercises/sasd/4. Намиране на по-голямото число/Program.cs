using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Намиране_на_по_голямото_число
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new List<int>();
            for (int i = 0; i < 2; i++)
            {
                arr.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(arr.Max());
        }
    }
}
