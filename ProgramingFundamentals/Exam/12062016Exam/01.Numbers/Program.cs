using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var list2 = new List<int>();

            

            decimal avarage = 0;

            foreach (var item in list)
            {
               avarage += item;                
               
            }
            avarage = avarage / (list.Count());


            foreach (var item in list)
            {
                if (item>avarage)
                {
                    list2.Add(item);
                }
                
            }
            
            list2.Sort();
            list2.Reverse();

           

            for (int i = 0; i < list2.Count() ; i++)
            {
                if (i<=4)
                {
                    Console.Write(list2[i] + " ");
                }
                
                
            }
            if (!list2.Any())
            {
                Console.WriteLine("No");
            }



        }
    }
}
