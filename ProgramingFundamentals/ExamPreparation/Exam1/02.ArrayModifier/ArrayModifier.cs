using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayModifier
{
    class ArrayModifier
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string [] command = new string[5];
            int position1 = 0;
            


            
            
            while (command[0]!="end")
            {
                command = Console.ReadLine().Split();
                if (command[0] == "swap")
                {

                    Swap(arr, int.Parse(command[1]), int.Parse(command[2]));

                    
                }
                else if (command[0]=="multiply")
                {
                    Mulitply(arr, int.Parse(command[1]), int.Parse(command[2]));
                }
                else if  (command[0] == "decrease")
                {
                    Decrease(arr);
                }
                    
                    
                                 
                
            }
            Console.WriteLine(String.Join(", ",arr));

           
                

        }
        static long [] Swap (long[]arr,int postion1, int position2)
        {
            long temp = arr[postion1]; // Copy the first position's element
            arr[postion1] = arr[position2]; // Assign to the second element
            arr[position2] = temp;
            return arr;
        }
        static long[] Mulitply(long[] arr, int postion1, int position2)
        {
                long temp = arr[position2] * arr[postion1];
            arr[postion1] = temp;
            
            return arr;
        }
        static long[] Decrease(long[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] - 1;
            }

            return arr;
        }

    }
}
