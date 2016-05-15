using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatorialAlgorithmsExercises
{
    class CombinatorialAlgorithmsExercises
    {
        static void Main()
        {
            int n = 3;
            int k = 2;

            int[] arr = new int[k];
            GenerateVariations(arr, n);

        }
        private static void GenerateVariations(int[] arr, int sizeOfSet, int index = 0)
        {
            if (index >= arr.Length) 
            {
                Print(arr);
            }
            else
            {
                for (int i = 1; i <= sizeOfSet; i++)
                {
                    arr[index] = i;
                    GenerateVariations(index + 1,;


                }
            }

        }
        private static void Print(int[]arr)
        {
            Console.WriteLine("({0})",string.Join(", ",arr));
        }
    }
}
