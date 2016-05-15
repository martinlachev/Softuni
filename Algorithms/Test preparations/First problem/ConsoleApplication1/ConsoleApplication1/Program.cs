using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        const int s = 2;

        static void Main(string[] args)
        {
            slm(s);
        }
        static void slm(int n)
        {
            if (n==n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(1);
                }  
            }
        }
    }
}
