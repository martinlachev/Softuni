using System;

class InfiniteRecursion
{
    static void Main()
    {
        Calulate(5);
    }

    static long Calulate(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        return Calulate(n);
    }
}
