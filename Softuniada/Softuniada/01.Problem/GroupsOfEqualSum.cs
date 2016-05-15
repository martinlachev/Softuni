using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem
{
class GroupsOfEqualSum
{
    static void Main()
    {   
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c= int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int sum = a + b + c + d;
        
        if (sum / 2 == (sum - (sum / 2)))
        {
            Console.WriteLine("Yes");
            Console.WriteLine(sum / 2);
        }
        else 
        {
            Console.WriteLine("No");
        }
    }
}
}
