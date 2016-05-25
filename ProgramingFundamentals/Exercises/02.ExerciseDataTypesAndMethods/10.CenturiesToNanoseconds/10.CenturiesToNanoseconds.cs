using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            decimal hours = 24 * days;
            decimal minutes = 60 * hours;
            decimal seconds = 60 * minutes;
            decimal milliseconds = 1000 * seconds;
            decimal microseconds = 1000 * milliseconds;
            decimal nanoseconds = 1000 * microseconds;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",centuries,years,days,hours,minutes,seconds,milliseconds,microseconds,nanoseconds);
        }
    }
}
