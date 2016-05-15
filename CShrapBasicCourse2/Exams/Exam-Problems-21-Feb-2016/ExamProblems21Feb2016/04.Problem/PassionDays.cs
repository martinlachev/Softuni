using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Problem
{
class PassionDays
{
    static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        string pokupki = " ";
        decimal sum = 0;
        int counter = 0;
        int starCounter = 0;
            string command = Console.ReadLine();
            if (command == "mall.Enter")
            {
                do
                {
                     pokupki = Console.ReadLine();
                     if (pokupki == "mall.Exit")
                     {
                         sum += 0;
                     }
                     else
                     {
                         sum += StringSplitter(pokupki);
                         starCounter = StarCounter(pokupki) * 10;
                         counter++;
                     }
                    

                } while (pokupki != "mall.Exit");
            }
            Console.WriteLine("{0} purchases. Money left: {1:F2} lv.",counter,((money+starCounter)-sum));

    }
    static decimal StringSplitter (string a)
    {
        decimal[] arr = new decimal[a.Length];
        decimal sum = 0;
        //Fill the Array
        for (int i = 0; i < a.Length; i++)
        {
            arr[i] = (int) a[i];
            
            if (arr[i]>=65 && arr[i]<=90)
            {
                if (true)
                {
                    
                }
                arr[i] = arr[i] - ((arr[i] * 50m) / 100m);
            }
            else if (arr[i]>=97 && arr[i]<=122)
            {
                arr[i] = arr[i] - ((arr[i] * 70m) / 100m);
            }
            else if (arr[i]==37)
            {
                arr[i] = arr[i] / 2m;
            }
            else if (arr[i] == 42)
            {
                arr[i] = 0;
                
            }
            else
            {
                arr[i] = arr[i];
            }
            sum += arr[i];
        }

        return sum;
    }
    static int StarCounter(string a)
    {
        int counter = 0;
        char[] arr = new char[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            arr[i] = a[i];
            if (arr[i] == '*')
            {
                counter++;
            }
        }
        return counter;
    }
}
}
