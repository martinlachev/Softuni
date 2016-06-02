using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Build_a_Matrix_of_Letters1
{
    class BuildAMatrixOfLetters
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            for (int i = 0; i <= row*col; i++)
            {
                
                 for (char k = (char)65; k <= (char)65 + row; k++)
                    {
                        Console.Write(k + i);
                    }
                
               
                
            }
        }
    }
}
