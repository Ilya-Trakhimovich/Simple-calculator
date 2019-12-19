using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    /// <summary>
    /// Class contains 3 methods for input the 
    /// first, the second numbers and math operation.
    /// </summary>
    public static class InputData
    {
        public static double firstNumber;
        public static double secondNumber;
        public static string mathOperation;

        /// <summary>
        /// Input validation
        /// </summary>
        private static bool isCorrect = true;

        /// <summary>
        /// The method for input the first number
        /// </summary>
        public static void EnterTheFirstNumber()
        {
            while (isCorrect)
            {
                Console.Write("Enter the fist number ");

                if (isCorrect = !double.TryParse(Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Wrong format! Try again.\n");
                }
            }

            isCorrect = true;
        }

        /// <summary>
        /// The method for input the second number
        /// </summary>
        public static void EnterTheSecondNumber()
        {
            while (isCorrect)
            {
                Console.Write("Enter the second number ");

                if (isCorrect = !double.TryParse(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Wrong format! Try again.\n");
                }
            }

            isCorrect = true;
        }

        /// <summary>
        /// The method for input math operation
        /// </summary>
        public static void EnterMathOperation()
        {
            while (isCorrect)
            {
                Console.WriteLine("Select operation: + - * /  ^ ");

                mathOperation = Console.ReadLine();

                if (mathOperation != "+" && mathOperation != "-" && mathOperation != "*" && mathOperation != "/" && mathOperation != "^")
                {
                    Console.WriteLine("Operation not define!. Try again!\n");
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                }
            }

            isCorrect = true;
        }
    }
}
