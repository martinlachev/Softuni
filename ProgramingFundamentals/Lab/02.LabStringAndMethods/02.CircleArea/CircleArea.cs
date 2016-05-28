using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CircleArea
{
    class CircleArea
    {
        static void Main()
        {
            double input = double.Parse(Console.ReadLine());
            sircleArea(input);
        }
        static void sircleArea(double input)
        {
            double circleArea = Math.PI * input * input;
            Console.WriteLine("{0:F12}",circleArea);
        }   
    }
}
