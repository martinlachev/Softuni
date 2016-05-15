using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem
{
class ImpressTheGirlfriend
{
    static void Main()
    {
        uint rubles = uint.Parse(Console.ReadLine());
        uint dollar =  uint.Parse(Console.ReadLine());
        uint euro = uint.Parse(Console.ReadLine());
        uint levaB =  uint.Parse(Console.ReadLine());
        uint levaM =  uint.Parse(Console.ReadLine());

        decimal convertRubles = (rubles / 100) * 3.5m;
        decimal convertDollar = dollar * 1.5m;
        decimal convertEuro = euro * 1.95m;
        decimal convertB = levaB / 2;

        if (convertRubles>convertDollar && 
            convertRubles>convertEuro &&
            convertRubles>convertB &&
            convertRubles>levaM)
        {
            Console.WriteLine("{0:F2}", Math.Ceiling(convertRubles));
        }

        if (convertDollar > convertRubles &&
           convertDollar > convertEuro &&
           convertDollar > convertB &&
           convertDollar > levaM)
        {
            Console.WriteLine("{0:F2}", Math.Ceiling(convertDollar));
        }

        if (convertEuro > convertRubles &&
          convertEuro > convertDollar &&
          convertEuro > convertB &&
          convertEuro > levaM)
        {
            Console.WriteLine("{0:F2}", Math.Ceiling(convertEuro));
        }

        if (convertB > convertRubles &&
          convertB > convertDollar &&
          convertB > convertEuro &&
          convertB > levaM)
        {
            Console.WriteLine("{0:F2}", Math.Ceiling(convertB));
        }

        if (levaM > convertRubles &&
          levaM > convertDollar &&
          levaM > convertEuro &&
          levaM > convertB)
        {
            Console.WriteLine("{0:F2}", Math.Ceiling((decimal)levaM));
        }


    }
}
}
