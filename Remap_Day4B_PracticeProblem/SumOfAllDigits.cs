using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day4B_PracticeProblem
{
    internal class SumOfAllDigits
    {
        public static void SumOfAllDigitsOfGivenNumber(int n3)
        {
            int sum = 0;
            while(n3 != 0)
            {
                sum += n3 % 10; //5
                n3 = n3 / 10; //4
            }
            Console.WriteLine("Sum of all digits is : {0}", sum);
        }
    }
}
