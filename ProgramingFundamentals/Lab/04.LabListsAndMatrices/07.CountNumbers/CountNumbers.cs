using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();

            list.Sort();

            int count = 0;

            for (int i = 1; i < list.Count; i++)
            {
                do
                {
                    count++;
                    if (list[i] != list[i-1])
                    {
                        
                        Console.WriteLine($"{list[i-1]} -> {count}");
                        count = 0;
                        
                    }
                    break;
                } while (list[i] == list[i-1]);
            }
           
        }
    }
}
