using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem
{
    class BaiIvanAdventures
    {
        static void Main()
        {
            int daysOfWeek =  int.Parse(Console.ReadLine());
            decimal baiIvanMoney =  decimal.Parse(Console.ReadLine());
            decimal wantedAlchohol = decimal.Parse(Console.ReadLine());
            decimal litersPerDay = 0;
            string baiIvanCondition ;

            switch (daysOfWeek)
            {
                case 0: litersPerDay = 25m; break;
                case 1: litersPerDay = 21m; break;
                case 2: litersPerDay = 14m; break;
                case 3: litersPerDay = 17m; break;
                case 4: litersPerDay = 45m; break;
                case 5: litersPerDay = 59m; break;
                case 6: litersPerDay = 42m; break;
                
            }
            decimal litterDrunk = baiIvanMoney/litersPerDay;//0.4
            //Bay Ivan Condition
            if (litterDrunk > 1.5m)
            {
                baiIvanCondition = "very drunk";
            }

            else if (litterDrunk >= 1.0m && litterDrunk<= 1.5m)
            {
                baiIvanCondition = "drunk";
            }
            else
            {
                baiIvanCondition = "sober";
            }
            //
            if (wantedAlchohol > litterDrunk)
            {
                Console.WriteLine( "Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends",baiIvanCondition,(wantedAlchohol-litterDrunk) );
            }
            if (litterDrunk == wantedAlchohol)
            {
                Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted",baiIvanCondition);
            }
            else
            {
                Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1} l. of alcohol",baiIvanCondition,wantedAlchohol-litterDrunk);
            }

        }
    }
}
