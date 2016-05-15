using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem
{
class TimeSpan
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(':');
        int days = int.Parse(arr[0]);
        int hours = int.Parse(arr[1]);
        int minutes = int.Parse(arr[3]);
        Console.WriteLine(days);
        Console.WriteLine(hours);
        Console.WriteLine(minutes);
    }
}
}
