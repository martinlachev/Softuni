using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            string firstArray = new string(arr);
            string secondArray = new string(arr2);

            int c = string.Compare(firstArray,secondArray);

            if (c == -1)
            {
                Console.WriteLine(String.Join("",arr));
                Console.WriteLine(String.Join("", arr2));
            }
            else
            {
                Console.WriteLine(String.Join("", arr2));
                Console.WriteLine(String.Join("", arr));
            }


        }
    }
}
