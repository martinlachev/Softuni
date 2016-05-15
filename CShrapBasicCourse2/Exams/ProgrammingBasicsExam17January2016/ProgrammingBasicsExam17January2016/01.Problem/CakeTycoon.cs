using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem
{
class CakeTycoon
{
    static void Main()
    {
        //Input
        long amountOFCake = long.Parse(Console.ReadLine());
        double kilogramsFlourNeeded = double.Parse(Console.ReadLine());
        long kilogramsOfFlourAvailable = long.Parse(Console.ReadLine());
        long amounthOfTruffels = long.Parse(Console.ReadLine());
        long priceOfTruffel = long.Parse(Console.ReadLine());
        //
       // Logic
        double cakesOfProducts = kilogramsOfFlourAvailable / kilogramsFlourNeeded;
        if (cakesOfProducts>amountOFCake)
        {
            double truffelsCost = amounthOfTruffels * priceOfTruffel;
            double cakePrice = (truffelsCost / amountOFCake) * 1.25;
            Console.WriteLine("All products available, price of a cake: {0:F2}",cakePrice);
        }
        else
        {
            int cast = (int)cakesOfProducts;
            double totalFlour = amountOFCake * kilogramsFlourNeeded;
            double kilogramsNeeded = totalFlour - kilogramsOfFlourAvailable;
            Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour",cast,kilogramsNeeded);

        }








    }
}
}
