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

            decimal input = decimal.Parse(Console.ReadLine());
            

            //For Sbyte
            if (input >= sbyte.MinValue && input<=sbyte.MaxValue )
            {
                if (input<0)
                {
                    Console.WriteLine("{0} can fit in:",input);
                    Console.WriteLine("* sbyte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");
                }
                else
                {
                    Console.WriteLine("{0} can fit in:",input);
                    Console.WriteLine("* sbyte");
                    Console.WriteLine("* byte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }                

            }

            //For Byte
            if (input >= byte.MinValue && input <= byte.MaxValue)
            {
                if (input<= sbyte.MaxValue)
                {
                    Console.WriteLine("{0} can fit in:",input);
                    Console.WriteLine("* sbyte");
                    Console.WriteLine("* byte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else
                {
                    Console.WriteLine("{0} can fit in:",input);
                    Console.WriteLine("* byte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }               

            }

            //For Short
            if (input >= short.MinValue && input <= short.MaxValue)
            {
                if (input < 0)
                {
                    Console.WriteLine("{0} can fit in:", input);                   
                    Console.WriteLine("* short");
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");
                }
                else
                {
                    Console.WriteLine("{0} can fit in:",input);
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }


            }

            //For UShort
            if (input >= ushort.MinValue && input <= ushort.MaxValue)
            {
                if (input <= short.MaxValue)
                {
                    Console.WriteLine("{0} can fit in:", input); 
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else
                {
                    Console.WriteLine("{0} can fit in:",input);
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }

            }

            //For Int
            if (input >= int.MinValue && input <= int.MaxValue)
            {
                if (input < 0)
                {
                    Console.WriteLine("{0} can fit in:", input);
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");
                }
                else
                {
                    Console.WriteLine("{0} can fit in:",input);
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }


            }

            //For UInt

            if (input >= uint.MinValue && input <= uint.MaxValue)
            {
                if (input <= int.MaxValue)
                {
                    Console.WriteLine("{0} can fit in:", input);
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else
                {
                    Console.WriteLine("{0} can fit in:",input);
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }

            }


            //For Long

            if (input >= long.MinValue && input <= long.MaxValue)
            {
                if (input < 0)
                {
                    Console.WriteLine("{0} can fit in:", input);
                    Console.WriteLine("* long");
                }
                
                else
                {
                    Console.WriteLine("{0} can fit in:",input);                    
                    Console.WriteLine("* long");
                }


            }

            //Bigger than long
            if (input> long.MaxValue || input < long.MinValue)
            {
                Console.WriteLine("{0} can't fit in any type",input);
            }


        }
    }
}
