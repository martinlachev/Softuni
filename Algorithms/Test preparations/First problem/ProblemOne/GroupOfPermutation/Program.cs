using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOfPermutation
{
    class Program
    {
        const int n = 5;
        const int k = 3;
        static int[] arr = new int[k];
        static void Main(string[] args)
        {
            GeneratePermutation(0); 
        }
        static void GeneratePermutation(int index) 
        {
            if (index == k)
            {
                Print(arr);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    arr[index] = i;
                    GeneratePermutation(index + 1);
                }
            }
        }
        static void Print(int [] arr)
        {
           
            
                Console.WriteLine(string.Join(", ",arr));
            
        }
    }
}
