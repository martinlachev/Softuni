using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ToUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = Regex.Replace(s, @"\<upcase\>(.*?)\</upcase\>",
                m => { var replaced = m.Groups[1].Value; return replaced.ToUpper(); });
            Console.WriteLine(result);
        }
    }
}
