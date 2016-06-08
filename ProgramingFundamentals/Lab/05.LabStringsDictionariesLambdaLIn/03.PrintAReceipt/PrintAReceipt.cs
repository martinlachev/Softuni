using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintAReceipt
{
    class PrintAReceipt
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ');
            decimal sum = 0;

            Console.WriteLine(@"/----------------------\");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("| {0,20:F2} |",decimal.Parse(arr[i]));
                sum += decimal.Parse(arr[i]);
            }

            Console.WriteLine("|----------------------|");
            Console.WriteLine("| Total:{0,14:F2} |", sum);
            Console.WriteLine(@"\----------------------/");

        }
    }
}
