using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (Regex.IsMatch(input,@"\d"))
            {
                Console.WriteLine("digit");
            }
            else if(!Regex.IsMatch(input, @"\d"))
            {
                switch (input)
                {
                    case "a": Console.WriteLine("vowel");break;
                    case "e": Console.WriteLine("vowel"); break;
                    case "o": Console.WriteLine("vowel"); break;
                    case "i": Console.WriteLine("vowel"); break;
                    case "y": Console.WriteLine("vowel"); break;

                    default:                        
                        break;
                }
            }
            else
            {
                Console.WriteLine("other");
            }

        }
    }
}
