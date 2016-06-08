using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().ToLower()
                         .Split(' ')                         
                         .ToList();
            var counts = new Dictionary<string, int>();
            var list = new List<string>();

            foreach (var num in nums)
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            
            foreach (var pair in counts)
            {
                if (pair.Value %2 != 0)
                {
                    list.Add(pair.Key);
                }
                

            }
            Console.WriteLine(String.Join(", ",list));



        }
    }
}
