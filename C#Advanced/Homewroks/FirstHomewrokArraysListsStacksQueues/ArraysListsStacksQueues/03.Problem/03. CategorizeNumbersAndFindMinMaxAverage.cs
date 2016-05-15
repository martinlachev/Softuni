using System;
using System.Collectioens.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem
{
    class Program
    {
        static void Main()
        {
            string [] input = Console.ReadLine().Split(' ');
            decimal [] arr = new decimal[input.Length];
            for (int i = 0; i < input.GetLength(0); i++)
            {
                arr[i] = decimal.Parse(input[i]);
            }
        }
        static decimal [] CategorizeNumbers(decimal [] arr)
        {
            decimal [] circleNumbers;
            decimal [] 
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] == Math.Floor(arr[i]))
                {
                    
                }
            }
        }
    }
}