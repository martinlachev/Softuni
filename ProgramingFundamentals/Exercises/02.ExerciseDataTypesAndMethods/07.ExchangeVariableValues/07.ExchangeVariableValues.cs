using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment
            int a = 5;
            int b = 10;
            //Printnig present values
            Console.WriteLine("Before: ");
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+ b);
            //Exchaging
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            //Printing after values
            Console.WriteLine("After: ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

        }
    }
}
