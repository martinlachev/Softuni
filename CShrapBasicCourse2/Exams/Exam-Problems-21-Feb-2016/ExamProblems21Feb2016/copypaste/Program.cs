using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copypaste
{
class Program
{
    static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        
        
        string pokupki = " ";
        decimal sum = 0;      
        
        int counter = 0;
        
        string command = Console.ReadLine();
        if (command == "mall.Enter")
        {
            do
            {
                pokupki = Console.ReadLine();
                counter++;
                decimal[] arr = new decimal[pokupki.Length];
                if (pokupki == "mall.Exit")
                {
                    sum += 0;
                    counter--;
                }
                else
                {
                    for (int i = 0; i < pokupki.Length; i++)
                    {
                        arr[i] = (decimal)pokupki[i];
                         if (arr[i] == 42)
                        {
                            arr[i] = 0;
                            money += 10;
                        }
                        else if (arr[i] >= 65 && arr[i] <= 90)
                        {
                            if (money < arr[i])
                            {
                                arr[i] = 0;
                            }
                            else
                            {
                                arr[i] = arr[i] - ((arr[i] * 50m) / 100m);
                            }
                            
                        }
                        else if (arr[i] >= 97 && arr[i] <= 122)
                        {
                            if (money < arr[i])
                            {
                                arr[i] = 0;
                            }
                            else
                            {
                                arr[i] = arr[i] - ((arr[i] * 70m) / 100m);
                            }
                            
                        }
                        else if (arr[i] == 37)
                        {
                            if (money < arr[i])
                            {
                                arr[i] = 0;
                            }
                            else
                            {
                                arr[i] = arr[i] / 2m;
                            }

                           
                        }                        
                        else
                        {
                            if (money < arr[i])
                            {
                                arr[i] = 0;
                            }
                            else
                            {
                                arr[i] = arr[i];
                            }
                            
                            
                        }
                        sum += arr[i];
                        
                    }


                    
                }


            } while (pokupki != "mall.Exit");
        }
        Console.WriteLine("{0} purchases. Money left: {1:F2} lv.", counter, (money - sum));

    }
}
}
