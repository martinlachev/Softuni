using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            int hi = int.Parse(Console.ReadLine());
            
            bool hui = hi == 1;
            Console.WriteLine(hui);
            
            if (hui == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            

        }
    }
}
