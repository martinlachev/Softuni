using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            ReverseString(input);

        }
        public static void ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(string.Join("", arr));
        }
        

    }
}
