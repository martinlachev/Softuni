using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PalindromeIndex
{
    class PalindromeIndex
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            if (IsPalindrome(a))
                Console.WriteLine("-1");
            else
                for (int i = 0; i < a.Length; i++)
                    if (IsPalindrome(a.Remove(i, 1)))
                    {
                        Console.WriteLine(i);
                        break;
                    }
        }

        static bool IsPalindrome(string a)
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] != a[a.Length - 1 - i]) return false;
            }
            return true;
        }
    }
}
