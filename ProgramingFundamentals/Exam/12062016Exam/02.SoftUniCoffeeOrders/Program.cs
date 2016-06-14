using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _02.SoftUniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var list = new List<decimal>();

            decimal total = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                string date = Console.ReadLine();
                decimal capsuleCount = int.Parse(Console.ReadLine());

                DateTime newDate = DateTime.ParseExact(date, "d/M/yyyy",CultureInfo.InvariantCulture);
                
                int days = DateTime.DaysInMonth(newDate.Year, newDate.Month);
                
                decimal result = ((days* capsuleCount)*pricePerCapsule);

                list.Add(result);


            }

            foreach (var item in list)
            {
                Console.WriteLine($"The price for the coffee is: ${item:F2}");

            }
            foreach (var item in list)
            {
                total += item;
            }

            Console.WriteLine($"Total: ${total:F2}");
            
        }
    }
}
