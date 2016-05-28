using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HolidaysBetweenTwoDates
{
    class Program
    {
        static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
              "d.M.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
           //var max = new DateTime(Math.Max(startDate.Ticks, endDate.Ticks));
           //var min =new DateTime( Math.Min(startDate.Ticks, endDate.Ticks));


            for (var date = startDate.Date; date.Date <= endDate.Date; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                } 
            }
                
            Console.WriteLine(holidaysCount);

        }
    }
}
