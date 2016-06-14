using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(' ').ToList();                
                
            var sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = ReverseString(list[i]);
                sum += int.Parse(list[i]);
            }

            Console.WriteLine(sum);
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
