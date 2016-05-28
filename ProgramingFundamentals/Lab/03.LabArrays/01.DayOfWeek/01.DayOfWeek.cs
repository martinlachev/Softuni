using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arr = { "pesho","Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday" };

            if (n>=1 && n<=7)
            {
                Console.WriteLine(arr[n]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }

        }
    }
}
