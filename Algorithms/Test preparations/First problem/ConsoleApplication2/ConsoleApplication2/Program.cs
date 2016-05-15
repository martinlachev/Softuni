using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
         
        static void Main()
        {
            int sumOfCol = 0;
            int sumOfRow = 0;
            int[,] arr = new int[2, 2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j <arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write(arr[i,j]+",");
                    sumOfCol = sumOfCol + arr[i] ;
                    sumOfRow = sumOfRow + i;



                }
                Console.WriteLine();
            }
            Console.WriteLine(sumOfCol);
            Console.WriteLine(sumOfRow);
            
            
        }
        
    }
}
