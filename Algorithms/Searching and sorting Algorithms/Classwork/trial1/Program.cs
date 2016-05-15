using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial1
{
    class Program
    {
        static void Main()
        {
            int [] j = new int[20] {5,3,4,2,43 };

            
            
            Console.Write("{0}\n", string.Join(",", j));
                
            


            selectionSort(j);

            Console.Write("{0}\n", string.Join(",", j));

           
            
        }
        static int tmp, posMin;
        static void selectionSort (int [] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                posMin = i;

                for (int j =i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[posMin])
                    {
                        posMin = j;
                    }
                }


                if (posMin != i)
                {
                    tmp = arr[i];
                    arr[i] = arr[posMin];
                    arr[posMin] = tmp;

                }
            }
        }
    }
}
