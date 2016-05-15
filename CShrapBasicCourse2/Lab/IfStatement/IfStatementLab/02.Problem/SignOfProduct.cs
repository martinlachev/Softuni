using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem
{
    class SignOfProduct
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            double product = firstNumber*secondNumber*thirdNumber;
          

            if (product >= 0)
            {
                Console.WriteLine("Positive");
            }
            if (product <0)
            {
                Console.WriteLine("Negative");
            }






        }
    }
}
