using System;
using System.Linq;

class NestedFor
{

    static int n;

    static int parse;
    static int[] arr;

    static void Main()
    {
        int parse = int.Parse(Console.ReadLine());
        n = parse;
        arr = new int[parse];
        Funkciq(0);
    }

    static void Funkciq(int index)
    {
        if (index >= n)
        {
            Print();
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                arr[index] = i;
                Funkciq(index + 1);
            }
        }
    }

    static void Print()
    {
        Console.WriteLine("({0})",
            string.Join(", ", arr));
        https://www.youtube.com/watch?v=0s0zh0zAaLg;
    }
}
