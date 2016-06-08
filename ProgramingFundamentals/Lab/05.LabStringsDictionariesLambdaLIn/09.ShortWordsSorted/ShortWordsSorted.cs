﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] separators = ".,:;()[]\"'\\/!? ".ToCharArray();

            var words = Console.ReadLine()
                .ToLower()
                .Split(separators,StringSplitOptions.RemoveEmptyEntries)
                .Where(x=> x.Length < 5)
                .OrderBy(x => x)
                .Distinct()
                .ToList();

            Console.WriteLine(String.Join(", ", words));


        }
    }
}
