using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem
{
class DrawAHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = n;

        char dot = '.';
        char plus = '+';
        char minus = '-';
        char asterics = '*';
        char cherta = '|';
        char space = ' ';
        int formula = ((n * 2) - 1) - 2;

        int dotcikul1 = n - 2;
        int edenicaPurviFor = 1;

        //First Line
        Console.Write(new string(dot,n-1) );
        Console.Write(new string(asterics, 1));
        Console.Write(new string(dot, n - 1));
        Console.WriteLine();
        // Second to n-2 Line
        for (int i = 0; i < n-2; i++)
        {
            Console.Write(new string(dot, dotcikul1));
            Console.Write(new string(asterics, 1));
            Console.Write(new string(space, edenicaPurviFor));
            Console.Write(new string(asterics, 1));
            Console.Write(new string(dot, dotcikul1));
            Console.WriteLine();
            dotcikul1--;
            edenicaPurviFor += 2;

        }
        //Next Line
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(asterics,1));
            Console.Write(new string(space,1));
            
        }
        Console.WriteLine();
        //Next Line
        Console.Write(new string (plus,1));
        Console.Write(new string(minus,formula));
        Console.Write(new string(plus, 1));
        Console.WriteLine();
        //Next Line
        for (int i = 0; i <n-2; i++)
        {
            Console.Write(new string(cherta,1));
            Console.Write(new string(space,formula));
            Console.Write(new string(cherta, 1));
            Console.WriteLine();
            
            
        }
        
        //Next Line
        Console.Write(new string(plus, 1));
        Console.Write(new string(minus, formula));
        Console.Write(new string(plus, 1));

    }
}
}
