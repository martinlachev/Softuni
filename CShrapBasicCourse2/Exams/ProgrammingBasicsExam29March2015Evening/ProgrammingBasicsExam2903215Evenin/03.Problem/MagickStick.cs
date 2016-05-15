using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem
{
    class MagickStick
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = (3 * n) + 2;
            int triPutiPoN = (3 * n) / 2;
            int purwiCiikuledenica = 1;
            int ravnoNaFour = width - 4;
            int edenica = 1;
            char asterics = '*';
            char dot = '.';

            //First line
            Console.Write(new string (dot,(width/2)));
            Console.Write(new string (asterics,1));
            Console.Write(new string(dot, (width / 2)));
            Console.WriteLine();
            //From Second to width / 5 line
            for (int i = 0; i < (width / 5); i++)
            {
                Console.Write(new string (dot,triPutiPoN));
                Console.Write(new string(asterics,1));
                Console.Write(new string (dot,purwiCiikuledenica));
                Console.Write(new string(asterics, 1));
                Console.Write(new string(dot, triPutiPoN));
                Console.WriteLine();
                triPutiPoN--;
                purwiCiikuledenica += 2;
            }
            //Next line
            Console.Write(new string (asterics,n));
            Console.Write(new string (dot,n+2));
            Console.Write(new string(asterics, n));
            Console.WriteLine();
            //Next Line
            for (int i = 0; i < (width / 7); i++)
            {
                Console.Write(new string (dot,edenica));
                Console.Write(new string(asterics, 1));
                Console.Write(new string(dot,ravnoNaFour));
                Console.Write(new string(asterics, 1));
                Console.Write(new string(dot, edenica));
                Console.WriteLine();
                ravnoNaFour -= 2;
                edenica++;

                
            }



        }
    }
}
