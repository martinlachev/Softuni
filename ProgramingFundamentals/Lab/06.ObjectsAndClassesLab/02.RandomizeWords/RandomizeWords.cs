using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').ToList();

            Random rnd = new Random();

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[rnd.Next(list.Count - 1)];
                
            }

            Console.WriteLine(String.Join(" ",list));
        }
    }
}
