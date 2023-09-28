using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day4B_PracticeProblem
{
    internal class DuplicateElement
    {
        public static void NumberOfTotalDuplicateElement()
        {
            Console.WriteLine("Enter number of element store in array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter elements store in array");
            for (int i  = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int duplicateElement = 0;
            
            for (int i = 0;i < n; i++)
            {
                for(int j=i+1;  j < n; j++)
                {
                    if (arr[j] == arr[i])
                        duplicateElement++;
                    
                }
               
            }
            Console.WriteLine("Number of duplicate element is : {0}", duplicateElement);
        }
    }
}
