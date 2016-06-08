using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FoldSum
{
    class FoldSum
    {
        static void Main()
        {
            var arr = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();

            int k = arr.Length / 4;

            var leftRow = arr.Take(k).Reverse();
            var rightRow =  arr.Reverse().Take(k);

            int[] row1 = leftRow.Concat(rightRow).ToArray();
            int[] row2 = arr.Skip(k).Take(2 * k).ToArray();

            var sumArr = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sumArr));



        }

    }
}
