using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day4B_PracticeProblem
{
    internal class FrequencyOfElement
    {
        public static void FrequencyOfEachElement()
        {
            Console.WriteLine("Enter number of element store in array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter elements store in array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Dictionary<int, int> elementsFrequency = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if (elementsFrequency.ContainsKey(i))
                {
                    elementsFrequency[i]++;
                }
                else
                {
                    elementsFrequency[i] = 1;
                    //duplicateElements.Add(i, 1);
                }
            }

            foreach (int key in elementsFrequency.Keys)
            {
                Console.WriteLine("Number of times " + key + " occurs: " + elementsFrequency[key]);
            }
        }
        
    }
}
