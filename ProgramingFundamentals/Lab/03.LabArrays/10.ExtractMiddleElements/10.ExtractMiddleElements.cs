using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                Split(' ').
                Select(int.Parse).
                ToArray();
            var middleArr = arr.Length / 2;

            if (arr.Length == 1)
            {
                Console.WriteLine("{ "+ arr[0]+ " }");
            }
            else if(arr.Length%2==0 )
            {
                Console.WriteLine("{ " + arr[middleArr-1] +", "+ arr[middleArr] + " }");
            }
            else if (arr.Length % 2 != 0)
            {
                Console.WriteLine("{ " + arr[middleArr - 1] + ", " + arr[middleArr] +", " +arr[middleArr+1]+ " }");
            }
        }
    }
}
