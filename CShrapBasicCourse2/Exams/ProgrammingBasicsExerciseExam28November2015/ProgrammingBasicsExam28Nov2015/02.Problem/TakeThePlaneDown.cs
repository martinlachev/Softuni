using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem
{
    class TakeThePlaneDown
{
    static void Main()
    {
        int headquatersCordinatesX =  int.Parse(Console.ReadLine());
        int headquatersCordinatesY =  int.Parse(Console.ReadLine());
        int distanceFromBorders =int.Parse(Console.ReadLine());
        int numberOfPlanes = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPlanes; i++)
        {
            int planeX = int.Parse(Console.ReadLine());
            int planeY = int.Parse(Console.ReadLine());

            if (planeX <= 0 && planeY >= 0)
            {
                planeX = int.MaxValue;
                planeY = int.MaxValue;
            }
            if (planeX <= headquatersCordinatesX + distanceFromBorders && planeY <= headquatersCordinatesY + distanceFromBorders )
            {
                
                Console.WriteLine("You destroyed a plane at [{0},{1}]",planeX,planeY);
            }
        }
    }
}
}
