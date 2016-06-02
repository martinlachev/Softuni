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
            int[] arr = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();
            List<int> position = new List<int>();

            for (int i = 1; i <arr.Length; i++)
            {
                if (arr[i] == arr[i-1])
                {
                    for (int l = 0; l < i; l++)
                    {
                        position.Add(arr[i]);
                    }
                }
               
            }
            Console.WriteLine(String.Join(" ",position));
        }
    }
}
