using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SeetDesert
{
    class SeetDesert
    {
        static void Main(string[] args)
        {
            var amountOfCash = decimal.Parse(Console.ReadLine());
            var numberOfGuets = int.Parse(Console.ReadLine());
            var priceOfBannasSU = decimal.Parse(Console.ReadLine());
            var priceOfEggsSU = decimal.Parse(Console.ReadLine());
            var proceOfberriesKilo  = decimal.Parse(Console.ReadLine());

            var portions = Math.Ceiling(numberOfGuets / 6m);
           
            decimal moneyNeeded = 
                  portions * (2m * priceOfBannasSU)
                + portions * (4m * priceOfEggsSU) 
                + portions * (0.2m * proceOfberriesKilo);

            if (moneyNeeded<=amountOfCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:F2}lv.");

            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {moneyNeeded-amountOfCash:F2}lv more.");
               
            }

        }
    }
}
