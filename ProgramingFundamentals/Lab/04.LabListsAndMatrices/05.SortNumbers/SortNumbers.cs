using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortNumbers
{
    class SortNumbers
    {
        static void Main()
        {
            List<double> list = Console.ReadLine().
                Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).
                Select(double.Parse).
                ToList();

            list.Sort();

            Console.WriteLine(String.Join(" <= ",list));



        }
    }
}
