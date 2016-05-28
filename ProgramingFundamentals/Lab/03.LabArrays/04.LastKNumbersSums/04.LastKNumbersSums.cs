using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] arr = new long[n];
            arr[0] = 1;
            

            for (long i = 1; i < n; i++)
            {
                arr[i] =SumOfSequence(arr,i - k, i - 1);
            }

            foreach (var item in arr)
            {
                Console.Write(item +" ");
            }

        }

        private static long SumOfSequence(long [] arr,long startIndex, long endIndex)
        {
            long sum = 0;

            for (long i = startIndex; i <= endIndex; i++)
            {
                if (i>=0)
                {
                    sum += arr[i];
                }
               

            }
            return sum;
        }
    }
}
