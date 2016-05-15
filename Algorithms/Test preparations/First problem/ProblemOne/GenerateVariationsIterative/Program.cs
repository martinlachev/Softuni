using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateVariationsIterative
{
    class Program
    {
        const int n = 4;
        const int k = 2;

        static int[] arr = new int[k];
        static void Main(string[] args)
        {
            do
            {
                Print(arr);

            } while (Increment(arr));
        }

        static bool Increment(int[] arr)
        {
            
            int digitIndex = arr.Length - 1;
            while (digitIndex >= 0)
            {
                arr[digitIndex]++;
                if (arr[digitIndex] == n)
                {
                    arr[digitIndex] = 0;
                    digitIndex--;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        static void Print(int[] arr)
        {
            Console.WriteLine(string.Join(", ",arr));
        }
    }
}
