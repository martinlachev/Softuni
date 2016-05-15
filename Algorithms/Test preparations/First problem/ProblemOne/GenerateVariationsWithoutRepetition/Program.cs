using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateVariationsWithoutRepetition
{
    class Program
    {
        // Изпитът Ви по Алгоритми - септември 2015 ще се проведе на 06/12/2015 (неделя) от 09:30 до 15:30 часа 
         //зала Code Ground Lab (гр. София, ул. Тинтява 15-17, партер). Вашето място в залата е 15I.
        const int n = 4;
        const int k = 2;
        static int[] arr = new int[k];
        static bool[] used = new bool[n];
        static void Main(string[] args)
        {
            GenVarWR(0);
        }

        private static void GenVarWR(int index)
        {
            if (index == k)
            {
                Print();
            }
            else 
            {
                for (int i = 0; i < n; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        arr[index] = i;
                        GenVarWR(index + 1);
                        used[i] = false;

                    }
                }
            }
        }

        private static void Print()
        {
            Console.WriteLine(string.Join(", ",arr));
        }
    }
}
