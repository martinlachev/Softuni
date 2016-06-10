using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftUniAirline
{
    class SoftUniAirline
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal total = 0;
            for (int i = 0; i < n; i++)
            {
                int adultPassangerCount = int.Parse(Console.ReadLine());
                decimal adultticketPrice = decimal.Parse(Console.ReadLine());
                int youthPassangerCount = int.Parse(Console.ReadLine());
                decimal youthticketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePHour = decimal.Parse(Console.ReadLine());
                int fuelConsumption = int.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                var income = (adultPassangerCount * adultticketPrice) + (youthPassangerCount * youthticketPrice);
                var expences = (flightDuration * fuelConsumption * fuelPricePHour);
                var profit = income - expences;
                total += profit;
                if (profit >= 0)
                {
                    Console.WriteLine($"You are ahead with {profit:F3}$.");
                }
                else
                {
                    Console.WriteLine($"We’ve got to sell more tickets! We’ve lost {profit:F3}$.");
                }

            }
            Console.WriteLine($"Overall profit -> {total:F3}$.");
            Console.WriteLine($"Average profit -> {total/n:F3}$.");
        }
        
    }
}
