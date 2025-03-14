using System.ComponentModel;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;

namespace Conditionals_shepardson_bruce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks user for a whole number and assigns to integer variable
            Console.WriteLine("Enter a whole number, please!");
            int myWholeNum = Convert.ToInt32(Console.ReadLine());

            // Checks if the number is positive or negative
            if (myWholeNum >= 0)
                Console.WriteLine($"{myWholeNum} is a positive number!");
            else
                Console.WriteLine($"{myWholeNum} is a negative number!");

            // Checks if the number is even or odd
            if (myWholeNum % 2 == 0)
            {
                Console.WriteLine($"{myWholeNum} is an even number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is an odd number!");
            }

            // Define other numbers for comparison
            int num1 = 6;
            int num2 = 99;

            // Find the maximum number
            int firstMax = Math.Max(myWholeNum, num1);
            int max = Math.Max(firstMax, num2);

            // Output the result
            Console.WriteLine($"The maximum number of {myWholeNum}, {num1}, and {num2} is {max}!");
            // asks user to enter a grade and assigns it to a char
            Console.WriteLine("enter a grade (A, B, C, D, F)!");
            char grade = Console.ReadKey().KeyChar;
            switch (grade)
            {  // prints description based on grade value
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nvery good");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage");
                    break;
                case 'D':
                    Console.WriteLine("\nBelow Average");
                    break;
                case 'F':
                    Console.WriteLine("\nfail");
                    break;
                default:
                    Console.WriteLine("\nYou did not enter a vaild grade!");
                    break;

            }
        }


    }
}
