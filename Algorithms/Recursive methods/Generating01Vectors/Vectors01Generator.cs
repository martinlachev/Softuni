using System;

class Vectors01Generator
{
    static void Gen01(int index, int[] hui)
    {
        if (index < 0)
        {
            Print(hui);
        }
        else
        {
            for (int i = 0; i <= 1; i++)
            {
                hui[index] = i;
                Gen01(index - 1, hui);
            }
        }
    }

    static void Print(int[] hui)
    {
        foreach (int i in hui)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
		
        int[] hui = new int[n];
		
        Gen01(n - 1, hui);
    }
}
