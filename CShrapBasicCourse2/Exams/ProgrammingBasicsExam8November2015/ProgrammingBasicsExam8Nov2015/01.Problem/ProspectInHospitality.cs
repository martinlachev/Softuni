using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem
{
    class ProspectInHospitality
    {
        static void Main()
        {
            uint amountOfBuilders =  uint.Parse(Console.ReadLine());
            uint amountOfReceptionists = uint.Parse(Console.ReadLine());
            uint amountOfChamberMaids = uint.Parse(Console.ReadLine());
            uint amountOfTechnichans = uint.Parse(Console.ReadLine());
            uint amountOfOtherStaff = uint.Parse(Console.ReadLine());
            decimal NikiSalary = decimal.Parse(Console.ReadLine());
            decimal usaRAte = decimal.Parse(Console.ReadLine());
            decimal yourSalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal Sum = SalaryCalculate(amountOfBuilders, amountOfReceptionists, amountOfChamberMaids, amountOfTechnichans, amountOfOtherStaff, NikiSalary, usaRAte, yourSalary);
            if (budget>Sum)
            {
                Console.WriteLine("The amount is: {0} lv.",Sum);
                Console.WriteLine(@"YES \ Left: {0} lv.",budget-Sum);
            }
            else
            {
                Console.WriteLine("The amount is: {0} lv.", Sum);
                Console.WriteLine(@"NO \ Need more: {0} lv.",Sum-budget);
            }
        }
        static decimal SalaryCalculate(uint b, uint r, uint c,uint t,uint o,decimal n,decimal u,decimal s)
        {
            decimal pablo = (b * 1500.04m) + (r * 2102.10m) + (c * 1465.46m) + (t * 2053.33m) + (o * 3010.98m) + (n * u) + s;
            return pablo;
        }
    }
}
