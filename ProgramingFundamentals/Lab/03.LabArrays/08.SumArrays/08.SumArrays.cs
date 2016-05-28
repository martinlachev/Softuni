using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                Split(' ').
                Select(int.Parse).
                ToArray();

            int[] arr2 = Console.ReadLine().
                Split(' ').
                Select(int.Parse).
                ToArray();

            


            var Max = Math.Max(arr.Length, arr2.Length);
            int[] sum = new int[Max];

            for (int i = 0; i < Max; i++)
            {
                for (int l = 0; l < Max; l++)
                {
                    sum[i] = arr[i % arr.Length] + arr2[i % arr2.Length];
                }
            }

            Console.WriteLine(String.Join(" ",sum));


        }
    }
}
