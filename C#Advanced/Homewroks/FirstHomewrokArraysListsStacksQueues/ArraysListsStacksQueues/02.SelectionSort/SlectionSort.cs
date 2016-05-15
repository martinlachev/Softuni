using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SelectionSort
{
class Program
{
    static void Main()
    {
        int[] arr = { 1, 3, 2, 4 };
        SelectionSort(arr);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("{0} ",arr[i]);
        }
    }
    static int[] SelectionSort(int [] arr)
    {
        int minus = 0;
        int temp = 0;
        for (int i = 0; i < arr.Length ; i++)
        {
            minus = i;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] < arr[minus])
                {
                    minus = j;
                }
            }
            temp = arr[minus];
            arr[minus] = arr[i];
            arr[i] = temp;
        }
        return arr;
    }
}
}
