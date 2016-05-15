using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            char tire = '-';
            int firstline = n / 2;
            int  firstlinetire = 1;
            int tridlinetire = 1;
            int  thirdline = n-2;

            //First Line
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string (tire,firstline));
                Console.Write(new string (c,firstlinetire));
                Console.Write(new string(tire, firstline));
                Console.WriteLine();
                firstline--;
                firstlinetire += 2;
            }
            //secondline
            Console.WriteLine(new string(c,n));
            //THird line 
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string (tire,tridlinetire));
                Console.Write(new string(c,thirdline));
                Console.Write(new string(tire, tridlinetire));
                Console.WriteLine();
                tridlinetire++;
                thirdline -= 2;
            }
        }
    }
}
