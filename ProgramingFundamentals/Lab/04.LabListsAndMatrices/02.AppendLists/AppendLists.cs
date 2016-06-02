using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class AppendLists
    {
        static void Main()
        {

            List<string> lists = Console.ReadLine().Split('|').Reverse().ToList();
            List<int> result = new List<int>();

            foreach (var item in lists)
            {
                List<int> currentLists = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                result.AddRange(currentLists);
            }

            Console.WriteLine(String.Join(" ",result));
        }
    }
}
