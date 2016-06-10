using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count_max = 0;
            int start_max = 0;
            int count = 0;
            for (int i = 0; i < array1.Length - 1; i++)
            {
                count = 0;
                while (array1[i + count] == array1[i + 1 + count])
                {
                    count++;
                    if (i + 1 + count > array1.Length - 1)
                    {
                        break;
                    }

                }
                if (count > count_max)
                {
                    count_max = count;
                    start_max = i;
                }

            }
            for (int i = start_max; i <= start_max + count_max; i++)
            {
                Console.Write($"{array1[i]} ");
            }
            Console.WriteLine();

        }
    }
}
