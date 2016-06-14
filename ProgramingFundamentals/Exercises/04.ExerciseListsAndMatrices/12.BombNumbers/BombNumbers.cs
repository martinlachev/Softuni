using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(String.Join(" ", list));
            Console.WriteLine(String.Join(" ", arr));

            

            

        }
        static List<int> Bombi(List<int> list,int[]arr)
        {
            foreach (var item in list)
            {
                if (item == arr[0])
                {
                    for (int i = item-arr[1]; i < item+arr[1]; i++)
                    {
                        list.Remove(item);
                    }
                }
            }
            return list;
        }
    }
}
