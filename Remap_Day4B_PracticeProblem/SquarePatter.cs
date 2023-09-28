using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day4B_PracticeProblem
{
    internal class SquarePatter
    {
        public static void SquarePatternOfStar(int n2)
        {
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    if (j == 0 || j == n2 - 1 || i == 0 || i == n2 - 1)
                    {
                        Console.Write("*");
                        continue;
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
