using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read an array of n integers (space separated on a single line) and an integer k, 
            //rotate the array right k times and sum the obtained arrays after each rotation as shown below.

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sumArray = new int[arr.Length];
            

            Console.WriteLine(String.Join(" ",RotateArr(arr, k, sumArray)));

        }
        static int[] RotateArr(int [] arr,int k,int [] sumArrays)
        {
            int numOfRotations = k;
            for (int i = 0; i < numOfRotations; i++)
            {

                int temp = arr[arr.Length - 1];                  
                for (int j = arr.Length-1; j >=1; j--)
                {
                    arr[j] = arr[j - 1];
                     
                }
                arr[0] = temp;
                for (int l  = 0; l < sumArrays.Length;l++)
                {
                    sumArrays[l] += arr[l];
                    
                }  
            }
            
            
            
            return sumArrays;
        }
    }
}
