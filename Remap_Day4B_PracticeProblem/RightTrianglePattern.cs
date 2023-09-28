using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day4B_PracticeProblem
{
    internal class RightTrianglePattern
    {
        public static void RightTrianglePatternOfStar(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine();
                for(int j = i; j <= n; j++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
