using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem
{
class CurrencyCheck
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        

        double rubles = (r/100d)*3.5d;
        double dollars = d*1.5d;
        double euro = e*1.95d;
        double bestOffer = b/2d;
        double poslednaM = (double) m;

        double minOne = Math.Min(rubles, dollars);
        double minTwo = Math.Min(euro, bestOffer);
        double minThree = Math.Min(minOne,minTwo);
        double minFour = Math.Min(minThree, poslednaM);
        Console.WriteLine("{0:F}", minFour);

      
        

    }
}
}
