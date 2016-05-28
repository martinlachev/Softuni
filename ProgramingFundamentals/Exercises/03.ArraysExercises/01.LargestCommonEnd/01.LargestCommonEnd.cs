using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');
            
            int counter = 0;
            int counter2 = 0;
            int startPostion = 0;
            var Min = Math.Min(arr.Length, arr2.Length);
            var Max = Math.Max(arr.Length, arr2.Length);

            for (int i = 0; i < Min; i++)
            {
                if (arr[i] == arr2[i])
                {
                    
                    counter++;
                }

            }

            

            while (counter2 < arr.Length &&
                   counter2 < arr2.Length)
            {
                if (arr[arr.Length - counter2 - 1] ==
                     arr2[arr2.Length - counter2 - 1])
                {
                    counter2++;
                }
                else break;
            }
            

            Console.WriteLine(Math.Max(counter,counter2));
            

        }
        
    }
}
