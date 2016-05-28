using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastNmae = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, {0} {1}. You are {2} years old.",name,lastNmae,age);
        }
    }
}
