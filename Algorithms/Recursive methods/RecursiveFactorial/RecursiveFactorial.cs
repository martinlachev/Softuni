using System;

class RecursiveFactorial
{
    static void Main()
    {
        Console.Write("n = ");
        int number = int.Parse(Console.ReadLine());

        decimal factorial = hui(number);
        Console.WriteLine("{0}! = {1}", number, factorial);
    }

    static decimal hui(int u)
    {
        if (u == 0)
        {
           return  1; 
        }
        else
        {
            return u * hui(u - 1);
        }
    }
}
