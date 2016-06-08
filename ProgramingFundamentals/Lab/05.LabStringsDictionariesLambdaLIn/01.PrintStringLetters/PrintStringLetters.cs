using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintStringLetters
{
    class PrintStringLetters
    {
        static void Main()
        {
            string n = Console.ReadLine();

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"str[{i}] -> '{n[i]}'");
            }
        }
    }
}
