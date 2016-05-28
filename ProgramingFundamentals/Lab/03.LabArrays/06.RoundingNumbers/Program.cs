using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine();
            double[] arr2 = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    arr2[i] = Math.Truncate((arr[i] - 0.5d));
                }
                else
                {
                    arr2[i] = Math.Truncate((arr[i] + 0.5d));
                }
                
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine($"{arr[i]} => {arr2[i]}");
            }
        }
    }
}
