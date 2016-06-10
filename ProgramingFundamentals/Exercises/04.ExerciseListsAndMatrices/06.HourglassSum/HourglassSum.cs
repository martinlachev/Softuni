using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.HourglassSum
{
    class HourglassSum
    {
        static void Main(string[] args)
        {
            decimal[,] inputMatrix = new decimal[6, 6];
            inputMatrix = (ReadingInput());

            decimal maxHourglasSum = (FindingMaxHourglassSum(inputMatrix));
            Console.WriteLine(maxHourglasSum);
        }

        static decimal FindingMaxHourglassSum(decimal[,] scannedMatrix)
        {
            decimal maxHGlassSum = 0;
            decimal currentHGlassSum = 0;

            for (int rowScan = 0; rowScan < scannedMatrix.GetLength(0) - 2; rowScan++)
            {
                for (int colScan = 0; colScan < scannedMatrix.GetLength(1) - 2; colScan++)
                {
                    currentHGlassSum = SumCurrentHGlass(scannedMatrix, rowScan, colScan); // sum items of current "Hourglass matrix" with start indexes - current values of rowScan, colScan
                    if (currentHGlassSum > maxHGlassSum)
                    {
                        maxHGlassSum = currentHGlassSum;
                    }
                }
            }
            return maxHGlassSum;
        }

        static decimal SumCurrentHGlass(decimal[,] sumProcessMatrix, int rowScan, int colScan)
        {
            decimal sumHG = 0; // the sum of current Hourglass shaped matrix
            for (int rowSum = rowScan; rowSum < rowScan + 3; rowSum++)
            {
                for (int colSum = colScan; colSum < colScan + 3; colSum++)
                {
                    if (rowSum == rowScan + 1 && (colSum == colScan || colSum == colScan + 2)) // skipping middle row's first and last elements
                    {
                        continue;
                    }
                    else
                    {
                        sumHG += sumProcessMatrix[rowSum, colSum];
                    }
                }
            }
            return sumHG;
        }

        static decimal[,] ReadingInput(int size = 6)
        {
            decimal[,] readMatrix = new decimal[size, size];

            for (int rowRead = 0; rowRead < size; rowRead++)
            {
                decimal[] inputRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

                for (int colRead = 0; colRead < size; colRead++)
                {
                    readMatrix[rowRead, colRead] = inputRow[colRead];
                }
            }
            return readMatrix;
        }
    }
}
