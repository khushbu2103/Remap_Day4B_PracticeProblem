using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day4B_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool execute = true;
            while(execute)
            {
                Console.WriteLine("Choose any peogram");
                Console.WriteLine("1. Number of duplicate element\n" +
                    "2. Unique element\n" +
                    "3. Frequency of Each element in array\n" +
                    "4. Maximun and minimum element in array\n" +
                    "5. Right triangle pattern of star\n" +
                    "6. Square pattern of star\n" +
                    "7. Reverse each word of string\n" +
                    "8. Sum of all digits of given number\n" +
                    "9. Sum of each row of matrix");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        DuplicateElement.NumberOfTotalDuplicateElement();

                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int decision1 = Convert.ToInt32(Console.ReadLine());
                        if (decision1 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 2:
                        UniqueElement.PrintAllUniqueEloement();

                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int decision2 = Convert.ToInt32(Console.ReadLine());
                        if (decision2 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 3:
                        FrequencyOfElement.FrequencyOfEachElement();

                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int decision3 = Convert.ToInt32(Console.ReadLine());
                        if (decision3 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 4:
                        MaxAndMinElement.MaximumAndMinimumElement();

                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int decision4 = Convert.ToInt32(Console.ReadLine());
                        if (decision4 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter number of elements required in first row of pattern");
                        int num = Convert.ToInt32(Console.ReadLine());
                        RightTrianglePattern.RightTrianglePatternOfStar(num);

                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int decision5 = Convert.ToInt32(Console.ReadLine());
                        if (decision5 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Enter number of elements required in first row of pattern");
                        int n2= Convert.ToInt32(Console.ReadLine());
                        SquarePatter.SquarePatternOfStar(n2);

                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int decision6 =  Convert.ToInt32(Console.ReadLine());
                        if (decision6 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 7:
                        //Console.WriteLine("Enter any word");
                        //string s = Convert.ToString(Console.ReadLine());
                        //ReverseEachWord.ReverseString(s);
                        Console.WriteLine("Enter any statement");
                        string input = Convert.ToString(Console.ReadLine());
                        ReverseEachWord.ReverseEachWordAtItsPosition(input);
                        break;
                    case 8:
                        Console.WriteLine("Enter any number (Atleast 2 digit number)");
                        int n3 = Convert.ToInt32(Console.ReadLine());
                        SumOfAllDigits.SumOfAllDigitsOfGivenNumber(n3);
                        break;
                    case 9:
                        SumOfMatrix.Run();
                        break;
                }
            }
           
            Console.ReadLine();
        }
    }
}
