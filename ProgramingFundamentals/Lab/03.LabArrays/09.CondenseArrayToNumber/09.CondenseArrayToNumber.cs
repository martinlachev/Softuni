using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().
                Split(' ').
                Select(int.Parse).
                ToArray();
            List<int> list = new List<int>();
            int counter = 0;
            int sum = 0;
            int sumList = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                                sum = nums[i] + nums[i - 1];
                list.Add(sum);
            }

            Console.WriteLine(String.Join(" ",list));
            Console.WriteLine(list.Sum());
        }
    }
}
