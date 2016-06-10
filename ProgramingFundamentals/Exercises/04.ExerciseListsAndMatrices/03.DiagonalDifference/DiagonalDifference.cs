using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt16(Console.ReadLine());
            int[,] arr = new int[N, N];
            string str = string.Empty;

            for (int i = 0; i < N; i++)
            {
                string[] strArr = Console.ReadLine().Split(' ');
                for (int j = 0; j < strArr.Length; j++)
                {
                    arr[i, j] = Convert.ToInt16(strArr[j]);
                }
            }

            int left = 0, right = N - 1, ldTotal = 0, rdTotal = 0;
            while (left < N)
            {

                ldTotal += arr[left, left];

                rdTotal += arr[left++, right--];
            }
            Console.WriteLine(Math.Abs(ldTotal - rdTotal));
        }
    }
}
