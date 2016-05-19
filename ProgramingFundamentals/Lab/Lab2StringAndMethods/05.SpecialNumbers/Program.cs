using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumOFn = SumOFN(i);
                if (sumOFn == 5 || sumOFn == 11 || sumOFn == 7)
                {
                    Console.WriteLine("{0} -> True",i);
                    
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }

            

        
        
        }
        static int SumOFN(int n)
        {
           int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
