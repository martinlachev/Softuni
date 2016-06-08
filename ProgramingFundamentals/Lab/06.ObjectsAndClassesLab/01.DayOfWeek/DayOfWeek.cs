using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace _01.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DateTime day = DateTime.ParseExact(input, "d-M-yyyy",CultureInfo.InvariantCulture);

            Console.WriteLine(day.DayOfWeek);
        }
    }
}
