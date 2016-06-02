using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            char [] arry = new char[]  { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' '};

            List<string> list = Console.ReadLine().
                Split(arry,StringSplitOptions.RemoveEmptyEntries).
                ToList();

            List<string> LowerCase = new List<string>();
            List<string> UpperCase = new List<string>();
            List<string> MixedCase = new List<string>();

            int counterUpper = 0;
            int counterLower = 0;

            foreach (var item in list)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (char.IsUpper(item[i]))
                    {
                        counterUpper++;
                    }
                    else if (char.IsLower(item[i]))                   
                    {
                        counterLower++;
                    }                  

                }
                if (counterLower == item.Length)
                {
                    LowerCase.Add(item);
                }
                else if (counterUpper == item.Length)
                {
                    UpperCase.Add(item);
                }
                else
                {
                    MixedCase.Add(item);
                }
                counterLower = 0;
                counterUpper = 0;

            }

           
           
            
            Console.Write("Lower case: ");
            Console.WriteLine(String.Join(", ",LowerCase));
            Console.Write("Mixed case: ");
            Console.WriteLine(String.Join(", ", MixedCase));
            Console.Write("Upper case: ");
            Console.WriteLine(String.Join(", ", UpperCase));



        }
        
         
    }
}
