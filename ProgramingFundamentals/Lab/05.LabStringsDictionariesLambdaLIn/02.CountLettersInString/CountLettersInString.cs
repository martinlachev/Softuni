using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountLettersInString
{
    class CountLettersInString
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToLower().ToCharArray();
            int counter = 1;
            Array.Sort(word);

            for (int i = 0; i < word.Length-1; i++)
            {
                if (word[i] == word[i+1])
                {
                    counter++;
                    if (i+1 == word.Length-1)
                    {
                        Console.WriteLine($"{word[i]} -> {counter}");
                    }
                }
                else
                {
                    Console.WriteLine($"{word[i]} -> {counter}");
                    counter = 1;
                }
            }

        }
    }
}
