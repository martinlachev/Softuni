using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem
{
    class HungryGarfield
    {
        static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal exchangeRate =decimal.Parse(Console.ReadLine());
            decimal pizzaPrice =decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice =decimal.Parse(Console.ReadLine());
            decimal sandwichPrize =decimal.Parse(Console.ReadLine());
            long pizzaQuantity =long.Parse(Console.ReadLine());
            long lasagnaQuantity = long.Parse(Console.ReadLine());
            long sandwichQuantity = long.Parse(Console.ReadLine());
            decimal diff = 0m;

            decimal moneyGarfieldNeeds = ((pizzaPrice/exchangeRate)* pizzaQuantity)+
                                         ((sandwichPrize/exchangeRate) * sandwichQuantity+
                                         (((lasagnaPrice/exchangeRate)* lasagnaQuantity)));
            if (moneyGarfieldNeeds<money)
            {
                diff = money - moneyGarfieldNeeds;
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:F2}.",(diff));
            }
            else
            {
                diff = moneyGarfieldNeeds - money;
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:F2}.",(diff));
            }




        }
    }
}
