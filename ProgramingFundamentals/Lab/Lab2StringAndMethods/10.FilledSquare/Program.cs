using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            PrintHeader(n);
            for (int i = 0; i < n-2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintHeader(n);
            
        }
        static void PrintMiddleRow(int n)
        {
            Console.Write("-");
            for (int i = 0; i < n-1; i++)
            {
                Console.Write(@"\/");
            }
            Console.WriteLine("-");
            
        }
        static void PrintHeader(int n)
        {
            for (int i = 0; i < n*2 ; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
