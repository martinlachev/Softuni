using System;

class SummerTime
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int bottleNeck = size + 1;
        int width = 2 * size;
        int hight = 3 * size + 1;

        int outerSpace = (width - bottleNeck) / 2;
        int innerSpace = bottleNeck - 2;

        Console.WriteLine("{0}{1}{0}", new string(' ', (width - bottleNeck) / 2), new string('*', bottleNeck));

        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string(' ', (width - bottleNeck) / 2), new string(' ', bottleNeck - 2));
        }
        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string(' ', outerSpace), new string(' ', innerSpace));

            outerSpace--;
            innerSpace += 2;
        }
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("*{0}*", new string('.', width - 2));
        }
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("*{0}*", new string('@', width - 2));
        }
        Console.WriteLine("{0}", new string('*', width));

        // width of the top                  --> N + 1             --> 8
        // bottom of the bottle              --> 2 * N             --> 14
        // height of the bottle              --> 3 * N + 1         --> 22


        //     ********       --> 8

        //     *      *
        //     *      *
        //     *      *

        //     *      *
        //    *        *
        //   *          *

        //  *............*
        //  *............*
        //  *............*
        //  *............*
        //  *............*
        //  *............*
        //  *............*

        //  *@@@@@@@@@@@@*
        //  *@@@@@@@@@@@@*
        //  *@@@@@@@@@@@@*
        //  *@@@@@@@@@@@@*
        //  *@@@@@@@@@@@@*
        //  *@@@@@@@@@@@@*
        //  *@@@@@@@@@@@@*

        //  **************     --> 14
    }
}