using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem
{
class SudokuResult
{
    static void Main()
    {
        int sum = 0;
        string input;
        do
        {
            input = Console.ReadLine();
            sum+=DateParse(input);
        } while (input != "Quit");
        Console.WriteLine(sum);
    }
    static int DateParse(string a)
    {
        DateTime parse = new DateTime(0, 0, 0, 0, 0, 0);
        
        DateTime wtf = parse.AddMinutes(double.Parse(a));

    
    }
}
}
