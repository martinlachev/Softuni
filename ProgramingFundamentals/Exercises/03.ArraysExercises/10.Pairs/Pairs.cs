using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs
{
    class Pairs
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());

            int pairs = 0;
            for (int i = 0; i < input.Length-1; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    if (Math.Abs(input[i] - input[j]) == diff)
                    {
                        pairs++;
                    }
                    
                }
            }
            Console.WriteLine(pairs);
        }
    }
}
