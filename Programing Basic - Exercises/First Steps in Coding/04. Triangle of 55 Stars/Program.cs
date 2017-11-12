using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Триъгълник_от_55_звездички
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('*', n));
                n++;
            }
        }
    }
}
