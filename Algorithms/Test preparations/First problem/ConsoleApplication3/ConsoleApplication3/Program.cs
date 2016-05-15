using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            fun(3, 4);
            
        }
        static void fun(int n, int k)
        {
            int rsault =  n + k;
            Console.WriteLine(rsault);
        }
        static void Print()
        {
            Console.WriteLine();
        }
    }
}
