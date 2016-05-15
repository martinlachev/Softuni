using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem
{
class BookProblem
{
    static void Main()
    {
        double pageNumber = double.Parse(Console.ReadLine());
        double campingDays = double.Parse(Console.ReadLine());
        double normalDaysRead = double.Parse(Console.ReadLine());

        double readingDays = 30 - campingDays;
        if (campingDays >=30 || normalDaysRead == 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            double pagesRead = readingDays * normalDaysRead;
            int mounths = (int)Math.Ceiling((double)pageNumber / pagesRead);            
            int years = mounths / 12;
            int m = mounths % 12;
            Console.WriteLine("{0} years {1} months", years, m);
        }
        
    }

        
}
}
