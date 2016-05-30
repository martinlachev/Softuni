using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();

            int k = arr.Length / 2;
            int splitK = k / 2;

            
            List<int> middle = new List<int>();
            List<int> outsideFirst = new List<int>();
            List<int> outsideSecond = new List<int>();
            List<int> sumOutside = new List<int>();

            for (int i = 0 ; i < arr.Length; i++)
            {
                if (i>=k-splitK && i<=k+splitK-1)
                {
                    middle.Add(arr[i]);
                }
                else if(i >= 0 && i <= splitK)
                {
                    outsideFirst.Add(arr[i]);
                }
                else
                {
                    outsideSecond.Add(arr[i]);
                }
            }

            outsideFirst.Reverse();
            outsideSecond.Reverse();

            foreach (var item in outsideFirst)
            {
                sumOutside.Add(item);

            }

            foreach (var item in outsideSecond)
            {
                sumOutside.Add(item);
            }

            var sum = middle.Zip(sumOutside, (x, y) => x + y).ToList();

           

            foreach (var item in sum)
            {
                Console.Write(item+" ");
            }
        }

    }
}
