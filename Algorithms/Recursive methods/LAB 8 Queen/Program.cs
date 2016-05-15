using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8_Queen
{
    class EightQueens
    {
        static void Main()
        {

        }

        const int Size = 8;
        static bool[,] chessboard = new bool[Size, Size];

        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedColomns = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();

        static void PutQueens(int row);
        {
        if(row == Size)

    }

}
