using System;

namespace _01.Lab
{
class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());        
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.Write("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|",
            firstNumber,
            Convert.ToString(firstNumber,2).PadLeft(10,'0'),
            secondNumber,
            thirdNumber);
        
    }
}
}
