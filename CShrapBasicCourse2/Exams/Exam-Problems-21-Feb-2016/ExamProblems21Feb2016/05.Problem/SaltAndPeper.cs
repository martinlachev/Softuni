using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.Problem
{
    class SaltAndPeper
    {
        static void Main()
        {
            BigInteger dishes = BigInteger.Parse(Console.ReadLine());
            string input = " ";
           
            do
            {
                input = Console.ReadLine();

            } while (input != "end");
            
        }
        static BigInteger SaltAndPeper(string input,BigInteger dishes)
        {

            string[] arr = input.Split(' ');
            string spices = arr[0];
            int step = int.Parse(arr[1]);

            if (spices == "salt")
            {
                string dishes1 = Convert.ToString(dishes);
                for (int i = 0; i <dishes1.Length ; i++)
                {
                    
                }
                return 1;
            }
            else
            {
                return 1 ;
            }
        }
    }
}
