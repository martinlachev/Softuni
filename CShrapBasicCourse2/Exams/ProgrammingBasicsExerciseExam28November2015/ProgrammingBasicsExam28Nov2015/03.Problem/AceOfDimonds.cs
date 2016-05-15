using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem
{
class AceOfDimonds
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char zvezda = '*';
        char tere = '-';
        char maimunka = '@';

        int firstForFormula = n/3;
        int firstForSecondFormula = 1;

        int secondForFormula = (n -4);
        int secondForSecondFormula = 1;


        //FirstLine
        Console.WriteLine(new string(zvezda,n));

        //Second Line to n/3 Line
        for (int i = 0; i < (n-2)/2; i++)
        {
            Console.Write("*{0}{1}{0}*", new string(tere, firstForFormula),
                new string(maimunka, firstForSecondFormula));
                firstForFormula--;
                firstForSecondFormula += 2;
                Console.WriteLine();
        }

        //Next Line 
        Console.WriteLine("*{0}*",new string(maimunka,n-2));

        //Next Line to n/3 Line
        for (int i = 0; i < (n-2)/2; i++)
        {
            if (n==3)
	        {
		        Console.Write("*{0}{1}{0}*", new string(tere,secondForSecondFormula),new string(maimunka,1));
                secondForSecondFormula++;
                Console.WriteLine();
	        }
            else
	        {
                Console.Write("*{0}{1}{0}*", new string(tere,secondForSecondFormula),new string(maimunka,secondForFormula));
                secondForSecondFormula++;
                secondForFormula -= 2;
            Console.WriteLine();
	        }
            
        }

        //Next Line 
        Console.WriteLine(new string(zvezda, n));


    }
}
}
