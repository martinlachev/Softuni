using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            GetMax(a,b,c);

        }
        static void GetMax(int a,int b,int c)
        {
            int[] arr = new int[3];
            arr[0] =  a;
            arr[1] = b;
            arr[2] = c;

            Array.Sort(arr);
            Console.WriteLine(arr[2]);
        }
    }
}
