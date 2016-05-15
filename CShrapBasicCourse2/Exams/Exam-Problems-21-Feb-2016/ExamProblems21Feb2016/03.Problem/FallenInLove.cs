using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem
{
    class FallenInLove
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char shrap = '#';
            char dot = '.';
            char wtf = '~';
            //First Line
            Console.WriteLine("##{0}##{0}##",new string(dot,(n*2)));

            //Seond Line to n-1 Line
            int wtfFormula = 1;
            int dotFormula = (n * 2) - 2;
            int dotFormula2 = 2;

            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#",
                                    new string (wtf,wtfFormula),
                                    new string (dot,dotFormula),
                                    new string (dot,dotFormula2));
                wtfFormula++;
                dotFormula -= 2;
                dotFormula2 += 2;

            }

            //NextLine  to n Line
            int dotFormula3N = 1;
            int wtfFormula2N = n;
            int dotFormula4N = n * 2;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}",
                                  new string (dot,dotFormula3N),
                                  new string(wtf,wtfFormula2N),
                                  new string(dot,dotFormula4N));
                dotFormula3N += 2;
                wtfFormula2N--;
                dotFormula4N -=2;
            }
            //NextLine
            Console.WriteLine("{0}####{0}",new string(dot,(n*2)+1));

            //LastLines

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}##{0}",new string(dot,((n*2)+2)));
            }



        }
    }
}
