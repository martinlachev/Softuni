using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TargetMultiplier
{
    class TargetMultiplier
    {
        static void Main(string[] args)
        {
            string rowsCols = Console.ReadLine();
            int r = int.Parse(rowsCols[0].ToString());
            int c = int.Parse(rowsCols[2].ToString());

            

            var matrix = new int[r][];

            for (int row = 0; row < r; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            string smallMatrix = Console.ReadLine();

            int sr = int.Parse(smallMatrix[0].ToString());
            int sc = int.Parse(smallMatrix[2].ToString());

            int sum = 0;

            for (int row = sr-1; row <= sr+1; row++)
            {
                for (int col = sc-1; col <= sc+1; col++)
                {
                     sum =+ matrix[row][col];
                    
                }
                
            }

            for (int row = sr - 1; row <= sr + 1; row++)
            {
                for (int col = sc - 1; col <= sc + 1; col++)
                {
                    matrix[row][col] *= matrix[row + 1][col + 1];

                }

            }
        }
    }
}
