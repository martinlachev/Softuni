using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem
{
class EncodedAnswers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[]arr = new char[n];
        int counterA = 0;
        int counterB = 0;
        int counterC = 0;
        int counterD = 0;
        //Fill the arr
        for (int i = 0; i < n; i++)
        {
            long input = long.Parse(Console.ReadLine());
            arr[i] = DoTheDevison(input);
            if (arr[i] == 'a')
            {
                counterA++;
            }
            else if (arr[i]=='b')
            {
                counterB++;
            }
            else if (arr[i] == 'c')
            {
                counterC++;
            }
            else if (arr[i] == 'd')
            {
                counterD++;
            }            
        }
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("{0} ",arr[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Answer A: {0}",counterA);
        Console.WriteLine("Answer B: {0}", counterB);
        Console.WriteLine("Answer C: {0}", counterC);
        Console.WriteLine("Answer D: {0}", counterD);
        
    }
    static char DoTheDevison(long a)
    {
        char result = ' ';
        long devison = a % 4;

        if (devison ==0)
        {
            result = 'a';
            return result;
        }
        else if (devison == 1)
        {
            result = 'b';
            return result;
        }
        else if (devison == 2)
        {
            result = 'c';
            return result;
        }
        else
        {
            result = 'd';
            return result;
        }
    }
}
}
