using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day4B_PracticeProblem
{
    internal class UniqueElement
    {
        public static void PrintAllUniqueEloement()
        {
            Console.WriteLine("Enter number of element store in array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter elements store in array");
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            for(int i = 0; i < n;i++)
            {
                bool isUnique = true;
                for(int j = i+1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                       
                    }
                }
                if (isUnique)
                {
                    Console.WriteLine("Unique element " + (i) + " is : " + arr[i]);
                }
            }
            

        }
    }
}
