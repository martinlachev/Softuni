using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(numbers);

            Console.WriteLine(get_occure(numbers));
            

        }
        public static int get_occure(int[] a)
        {
            int[] arr = a;
            int c = 1, maxcount = 1, maxvalue = 0;
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                maxvalue = arr[i];
                for (int j = 0; j < arr.Length; j++)
                {

                    if (maxvalue == arr[j] && j != i)
                    {
                        c++;
                        if (c > maxcount)
                        {
                            maxcount = c;
                            result = arr[i];

                        }
                    }
                    else
                    {
                        c = 1;

                    }

                }


            }
            return result;
        }
    }
}
