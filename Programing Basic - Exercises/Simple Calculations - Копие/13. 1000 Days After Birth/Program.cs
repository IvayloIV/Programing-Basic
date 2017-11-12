using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture)
                .AddDays(999)
                .ToString("dd-MM-yyyy"));
        }
    }
}
