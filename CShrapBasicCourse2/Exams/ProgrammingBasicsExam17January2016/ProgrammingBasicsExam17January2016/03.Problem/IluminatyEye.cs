using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem
{
    class IluminatyEye
    {
        static void Main()
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            //Basic data
            int heightOfTheEye = n + 1;
            int width = 3 * n;

            //Formulas for first loop.
            int firstLoopFormula = width-((2*n)+2);
            int firstLoopMiddle = 0;

            //Characters
            char dot = '.';
            char hash = '#';

            //First Line 
            Console.WriteLine("{0}{1}{0}",new string(dot,n),new string(hash,n));

            //First Loop(Second to n/2 Line)
            for (int i = 0; i < n/2; i++)
            {
                Console.Write("{0}##{1}#{2}#{1}##{0}",
                    new string(dot,firstLoopFormula),
                    new string(dot,firstLoopMiddle),
                    new string(dot, width - ((2 * n) + 2)));

                firstLoopFormula -= 2;
                firstLoopMiddle += 2;
                Console.WriteLine();
            }
            //Formula for second loop
              int secondFormula = 1;
                int secondmiddle = n-3;
            //Second Loop
            for (int i = 0; i < n/2; i++)
            {
                Console.Write("{0}##{1}#{2}#{1}##{0}",
                    new string(dot,secondFormula),
                    new string(dot,secondmiddle),
                    new string(dot, width - ((2 * n) + 2)));
                secondFormula+=2;
                secondmiddle -= 2;
                Console.WriteLine();
            }
            //Last Line
            Console.WriteLine("{0}{1}{0}", new string(dot, n), new string(hash, n));

        }
    }
}
