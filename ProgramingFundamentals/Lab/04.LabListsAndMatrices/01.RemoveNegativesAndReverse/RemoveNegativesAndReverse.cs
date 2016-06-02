using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                    .Split(' ').Select(int.Parse).ToList();
            List<int> list2 = new List<int>(); 

            foreach (var item in list)
            {
                if (item>0)
                {
                    list2.Add(item);
                }
            }

            if (!list2.Any())
            {
                Console.WriteLine("empty");
            }
            else
            {
                list2.Reverse();
                Console.WriteLine(String.Join(" ",list2));
            }

            

        }
    }
}
