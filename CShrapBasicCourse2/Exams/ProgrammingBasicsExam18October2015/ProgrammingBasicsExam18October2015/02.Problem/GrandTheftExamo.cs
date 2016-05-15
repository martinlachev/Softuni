using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem
{
class GrandTheftExamo
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint thivesSlpaped = 0;
        uint thivesEscaped = 0;
        uint sixpacks = 0;
        uint beersLeft = 0;
        uint sumThivesSlapped=0;
        uint sumThivesEscaped=0;
        uint sumSixpack = 0;
        uint sumBeerLeft = 0;
        for (int i = 0; i < n; i++)
        {
            uint thivesEscapeAttempt = uint.Parse(Console.ReadLine());
            uint beerVonApovbegerDrinks = uint.Parse(Console.ReadLine());

            if (thivesEscapeAttempt>5)
            {
                thivesSlpaped = 5;
                thivesEscaped = thivesEscaped - thivesSlpaped;
                if (beerVonApovbegerDrinks>=6)
                {
                    sixpacks = beerVonApovbegerDrinks / 6;
                    beersLeft = beerVonApovbegerDrinks % 6;

                }
                else
                {
                    sixpacks = 0;
                    beersLeft = beerVonApovbegerDrinks;
                }

            }

            else
            {
                thivesSlpaped = thivesEscapeAttempt;
                thivesEscaped = 0;
                if (beerVonApovbegerDrinks >= 6)
                {
                    sixpacks = beerVonApovbegerDrinks / 6;
                    beersLeft = beerVonApovbegerDrinks % 6;

                }
                else
                {
                    sixpacks = 0;
                    beersLeft = beerVonApovbegerDrinks;
                }

            }

            sumThivesSlapped += thivesSlpaped;
            sumThivesEscaped += thivesEscaped;
            sumSixpack += sixpacks;
            sumBeerLeft += beersLeft;

        }
        Console.WriteLine("{0} thieves slapped.",sumThivesSlapped);
        Console.WriteLine("{0} thieves escaped.",sumThivesEscaped);
        Console.WriteLine("{0} packs, {1} bottles.",sumSixpack,sumBeerLeft);
    }
    
}
}
