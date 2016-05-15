using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BabaTinche
{
    static void Main(string[] args)
    {
        // Input
        string[] firstLine = Console.ReadLine().Split(' ');
        string[] secondLine = Console.ReadLine().Split(' ');
        string[] thirdLine = Console.ReadLine().Split(' ');
        // Integers for first LINE
        int passangers = int.Parse(firstLine[0]);
        int frequentFlyars = int.Parse(firstLine[1]);
        int passMeals = int.Parse(firstLine[2]);
        // Formula
        double FormulaForFirstLine = (passangers - frequentFlyars) * 7000 + (((7000 * 30) / 100) * frequentFlyars) + (((7000 * 0.5) / 100) * passMeals);
        

        // Integers for second LINE
        int secondPassangers = int.Parse(secondLine[0]);
        int secondFrequentFlyars = int.Parse(secondLine[1]);
        int secondPassMeals = int.Parse(secondLine[2]);
        // Formula
        double FormulaForSecondLine = (secondPassangers - secondFrequentFlyars) * 3500 + (((3500 * 30) / 100) * secondFrequentFlyars) + ((3500 * 0.5) / 100) * secondPassMeals;
        
        // Integers for third LINE
        int thirdPassangers = int.Parse(thirdLine[0]);
        int thirdFrequentFlyars = int.Parse(thirdLine[1]);
        int thirdPassMeals = int.Parse(thirdLine[2]);
        // Formula
        double FormulaForThirdLine = (thirdPassangers - thirdFrequentFlyars) * 1000 + (((1000 * 30) / 100) * thirdFrequentFlyars) + ((1000 * 0.5) / 100) * thirdPassMeals;
       
        // Output
        int cqlataFormula = (int)(FormulaForFirstLine + FormulaForSecondLine + FormulaForThirdLine);
        Console.WriteLine(cqlataFormula);
        double maxformula = (7000 * 12) + (3500 * 28) + (50 * 1000) + ((7000 * 12) * (0.5 / 100) + ((3500 * 28)*(0.5 / 100)) + ((50 * 1000)*(0.5 / 100)));
        int difference = (int)maxformula - cqlataFormula;
        Console.WriteLine(difference);



    }
}
