using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();

            List<int> list2 = new List<int>();
            

            foreach (var item in list)
            {
                if (Math.Sqrt(item) == (int)Math.Sqrt(item))
                {
                    list2.Add(item);
                }
            }
            list2.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(String.Join(" ",list2));
        }
    }
}
