using System;
using System.Linq;

class NestedFor
{
    static int k;

    static int n;

    static int parse;

    static int parse2;

    static int[] arr;

    static void Main()
    {
        int parse = int.Parse(Console.ReadLine());
        int parse2 = int.Parse(Console.ReadLine());
        n = parse;
        k = parse2;
        arr = new int[parse2];
        Funkciq(0);
    }

    static void Funkciq(int index)
    {
        if (index >= k)
        {
            Print();
        }
        else
        {
            for (int i = 1; i < n; i++)
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

    }
}
