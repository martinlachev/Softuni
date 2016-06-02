using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main()
        {
            List<double> list = Console.ReadLine().
                                                 Split(' ').
                                                 Select(double.Parse).
                                                 ToList();
            bool hasAdjacentEqualNumbers = true;

            while (hasAdjacentEqualNumbers)
            {
                hasAdjacentEqualNumbers = false;

                for (int cuurrentElement = 0; cuurrentElement < list.Count-1; cuurrentElement++)
                {
                    if (list[cuurrentElement] == list[cuurrentElement+1])
                    {
                        list[cuurrentElement] *= 2;
                        list.RemoveAt(cuurrentElement + 1);
                        hasAdjacentEqualNumbers = true;
                    }
                    
                }
                
            }
            Console.WriteLine(String.Join(" ",list));

        }
    }
}
