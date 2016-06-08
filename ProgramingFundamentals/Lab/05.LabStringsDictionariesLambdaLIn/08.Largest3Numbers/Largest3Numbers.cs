using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList().OrderBy(x => -x).Take(3);

            Console.WriteLine(String.Join(" ",list));
        }
    }
}
