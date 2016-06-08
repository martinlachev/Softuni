using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OccurrencesInString
{
    class OccurrencesInString
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            int counter = 0;
            int offset = -1;
            
            while (true)
            {
                offset = text.IndexOf(word, offset + 1);
                if (offset == -1) break;
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
