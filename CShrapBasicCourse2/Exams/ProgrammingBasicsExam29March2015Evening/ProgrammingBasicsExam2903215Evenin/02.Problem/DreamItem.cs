using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem
{
class DreamItem
{
    static void Main()
    {
        string [] input = Console.ReadLine().Split('\\');
        string monnth = input[0];
        decimal moneyPerHour = decimal.Parse(input[1]);
        decimal hoursPerDay = decimal.Parse(input[2]);
        decimal priceOfItem = decimal.Parse(input[3]);
        int days = 0;
        

        switch (monnth)
        {
            case "Jan": days = 31;
                break;
            case "Feb": days = 28;
                break;
            case "Mar": days = 31;
                break;
            case "Apr": days = 30;
                break;
            case "May": days = 31;
                break;
            case "Jun": days = 30;
                break;
            case "Jul": days = 31;
                break;
            case "Aug": days = 31;
                break;
            case "Sep": days = 30;
                break;
            case "Oct": days = 31;
                break;
            case "Nov": days = 30;
                break;
            case "Dec": days = 31;
                break;    
            default:
                break;
        }
        days = days -10;

        decimal moneyPerMounth = days * moneyPerHour * hoursPerDay;
        

        if (moneyPerMounth>700)
        {
            moneyPerMounth = moneyPerMounth + ((moneyPerMounth * 0.1m));
        }

        if ((moneyPerMounth-priceOfItem) > 0 )
        {
            decimal difference = moneyPerMounth - priceOfItem; 
            Console.WriteLine("Money left = {0:F2} leva.",difference);
        }
        else
        {
            decimal differenceTwo = priceOfItem - moneyPerMounth;
            Console.WriteLine("Not enough money. {0:F2} leva needed.",differenceTwo);
        }


            

        

       
    }
}
}
