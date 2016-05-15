using System;

namespace _17.ExamProblem
{
    class Dumbbell
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char dot = '.';
            char aesterics = '*';
            char equal = '=';
            char ampersant = '&';

            int innerDots = n;
            int outerDotsTwo = (n / 2) - 1;
            int outerDots = (n / 2);
            int ampersantDot = (n / 2) + 1;

            int newformulae = 1;
            int oldnewformulae = n - 3;




            Console.WriteLine("{0}{1}{2}{1}{0}",
           new string(dot, outerDots),
           new string(ampersant, ampersantDot),
           new string(dot, n));


            for (int i = 0; i < (n / 2) - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                    new string(dot, outerDotsTwo),
                    new string(ampersant, 1),
                    new string(aesterics, outerDots),
                    new string(dot, n));
                outerDotsTwo--;
                outerDots++;
            }

            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}",
                new string(ampersant, 1),
                new string(aesterics, outerDots),
                new string(equal, n));


            for (int i = 0; i < (n / 2) - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                    new string(dot, newformulae),
                    new string(ampersant, 1),
                    new string(aesterics, oldnewformulae),
                    new string(dot, n));
                newformulae++;
                oldnewformulae--;
            }

            Console.WriteLine("{0}{1}{2}{1}{0}",
           new string(dot, n / 2),
           new string(ampersant, n / 2 + 1),
           new string(dot, n));






        }
    }
}
