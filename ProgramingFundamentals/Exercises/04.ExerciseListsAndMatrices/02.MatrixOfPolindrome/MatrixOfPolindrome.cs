using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MatrixOfPolindrome
{
    class MatrixOfPolindrome
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int matrixRows = int.Parse(input [0].ToString());
            int matrixCols = int.Parse(input[2].ToString());

            string[,] polidromesMatrix = new string[matrixRows, matrixCols];

            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    polidromesMatrix[row, col] = "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);


                }
            }

            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    Console.Write(polidromesMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
