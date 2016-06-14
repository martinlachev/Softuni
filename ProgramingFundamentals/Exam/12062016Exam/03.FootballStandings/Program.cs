using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.FootballStandings
{
    class Program
    {
        static void Main(string[] args)
        {
           string symbol = Console.ReadLine();
           string input = "";
            
           var list2 = new List<string>();
           var getResult = new List<int>();
           var dic = new Dictionary<string, int>();
            while (input != "final")
           {
                input = Console.ReadLine();
                if (input != "final")
                {
                    string numbers = GetNumbers(input);
                    
                    input = GetSubStrings(input, symbol, symbol) +  numbers;
                    var list = input.Split(' ').ToList();
                    Console.WriteLine(String.Join(" ",list));

                    if (int.Parse(list.ElementAt(2))> int.Parse(list.ElementAt(3)))
                    {
                        
                    }
                   

                    
                }            
                
                
                

            }

           
        }
        static string GetSubStrings(string input, string start, string end)
        {
            string result = "";
            Regex r = new Regex(Regex.Escape(start) + "(.*?)" + Regex.Escape(end));
            MatchCollection matches = r.Matches(input);
            foreach (Match match in matches)
            {
                 result += match.Groups[1].Value.ToString()+" ";
            }
           
            return result;                 
            

        }
        static string GetNumbers(string input)
        {
            string result = "";
            Regex r = new Regex(@"[\d]");
            MatchCollection matches = r.Matches(input);
            foreach (Match match in matches)
            {
                result += match.Groups[0].Value.ToString() + " ";
            }

            return result;
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);

           
        }
    }
}
