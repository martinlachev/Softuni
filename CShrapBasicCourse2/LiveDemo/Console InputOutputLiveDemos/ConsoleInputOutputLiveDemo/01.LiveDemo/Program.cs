using System;

namespace _01.LiveDemo
{
class Program
{
    static void Main()
    {
        string name = "Pesho";
        int year = 56;
        double avarageGrade = 0.5;
        string schoolName = "SoftUni";
        Console.WriteLine("{0}\n{1}\n{2}\n{3}",name,year,avarageGrade,schoolName);

        double pi = Math.PI;
        int deset = 10;
        Console.WriteLine("{0:F2}",pi);
        Console.WriteLine("|{0,10}|",deset);
        Console.WriteLine("{0} e mnogo gotin pich",name);

    }
}
}
