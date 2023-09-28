using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day4B_PracticeProblem
{
    internal class SumOfMatrix
    {
        public static void Run()
        {
            int sum = 0;
            int row = 0;
            int col = 0;
            int[,] Matrix;
           

            Console.WriteLine("Enter the number of rows in the matrix: ");
            row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns in the matrix: ");
            col = Convert.ToInt32(Console.ReadLine());

            Matrix = new int[row, col];
           
            Random random = new Random();
            for(int i = 0; i < row; i++)
            {
                
                for (int j = 0; j < col; j++)
                {
                    Matrix[i,j] = random.Next(0, 101);
                    Console.Write(Matrix[i, j] + " ");

                }
                Console.WriteLine();
            }
            
            for(int i = 0; i< row; i++)
            {
                for(int j = 0; j < col;j++)
                {
                    sum += Matrix[i,j];
                }
                Console.WriteLine("Sum of row " + (i + 1) + " is: " + sum);
            }
           
        }
    }
}
