using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static int[] arr = new int [] { 'A','B','C'};
        static void Main()
        {
            Perm(arr, 0);
        }

        private static void Perm <T> (T[] arr, int k)
        {
            if (k == arr.Length)
            {
                Print(arr);
            }
            else
            {
                Perm(arr, k + 1);
                for (int i = k+1; i < arr.Length; i++)
                {
                    Swap
                }
            }
        }

        private static void Print<T>(T[]arr)
        {
            Console.WriteLine(string.Join(",",arr));
        }

        static void Swap<T>(ref T first, T second)
        {
            T oldFirst = first;
            first = second;
            second =  oldFirst;

        }
    }
}
