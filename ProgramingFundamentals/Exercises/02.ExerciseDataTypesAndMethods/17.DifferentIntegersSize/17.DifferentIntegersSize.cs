using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {

            long input = int.Parse(Console.ReadLine());
            string result = "";

            if (input >= sbyte.MinValue && input<=sbyte.MinValue )
            {
                if (true)
                {
                    
                }
                Console.WriteLine("{0} can fit in:");
                Console.WriteLine("* sbyte");
                Console.WriteLine("* byte");
                Console.WriteLine("* short");
                Console.WriteLine("* ushort");
                Console.WriteLine("* int");
                Console.WriteLine("* uint");
                Console.WriteLine("* long");

            }
            if (input >= byte.MinValue && input <= byte.MinValue)
            {
                Console.WriteLine("{0} can fit in:");               
                Console.WriteLine("* byte");
                Console.WriteLine("* short");
                Console.WriteLine("* ushort");
                Console.WriteLine("* int");
                Console.WriteLine("* uint");
                Console.WriteLine("* long");

            }

            if (input >= short.MinValue && input <= short.MinValue)
            {
                Console.WriteLine("{0} can fit in:");                
                Console.WriteLine("* short");
                Console.WriteLine("* ushort");
                Console.WriteLine("* int");
                Console.WriteLine("* uint");
                Console.WriteLine("* long");

            }
            if (input >= ushort.MinValue && input <= ushort.MinValue)
            {
                Console.WriteLine("{0} can fit in:");
                Console.WriteLine("* short");
                Console.WriteLine("* ushort");
                Console.WriteLine("* int");
                Console.WriteLine("* uint");
                Console.WriteLine("* long");

            }


        }
    }
}
