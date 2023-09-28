using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day4B_PracticeProblem
{
    internal class MaxAndMinElement
    {
        public static void MaximumAndMinimumElement()
        {
            Console.WriteLine("Enter number of element store in array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter elements store in array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0];
            int min = arr[0];
            for(int i = 0; i < n;i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum element: " + max);
            Console.WriteLine("Minimum element: " + min);
        }
    }
}
