using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ');
            int[] arr2 = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr2[i] =int.Parse( arr[i]);
            }
            Array.Sort(arr2);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("{0} ",arr2[i]);
            }
        }
    }
}
