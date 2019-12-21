using System;
using System.Linq;

namespace ConsoleApp10
{
    public static class OneLine
    {
        /// <summary>
        /// String expression from user
        /// </summary>
        private static string expression;

        /// <summary>
        /// Variable for check the first number 
        /// </summary>
        private static bool isCorrectFirstNumber = default;

        /// <summary>
        /// variable for check the second number
        /// </summary>
        private static bool isCorrectSecondNumber = default;

        /// <summary>
        /// Variable for get math operation from expression
        /// </summary>
        private static string operation = default;

        /// <summary>
        /// Value of first number after validations
        /// </summary>
        private static double firstNumber;

        /// <summary>
        /// Valuse of the second number after validations
        /// </summary>
        private static double secondNumber = default;

        private static double result = default;

        /// <summary>
        /// The method allows to enter string expression
        /// </summary>
        public static void EnterExpression()
        {
            Console.WriteLine($"\nInformation: The calculator counts only 2 numbers.\n" +
                              $"It is allowed to use positive and negative numbers.\n" +
                              $"Allowed operations: + - * / ^\n" +
                              $"Expression must end with '='");
            Console.WriteLine("Example: x + y =\n");
            Console.Write("Enter expression: ");

            expression = Console.ReadLine().Replace(" ", "");
        }

        /// <summary>
        /// The method does validation input data
        /// </summary>
        public static void ValidationInputData() 
        {
            bool isNegative = true; // check negative number

            try
            {
                if (expression[0] == '+') // check first character for negative number
                {
                    expression = expression.Remove(0, 1); 
                }
                else if (expression[0] == '-')
                {
                    expression = expression.Remove(0, 1); // check first character for negative number
                    isNegative = false;
                }

                int indexOfMathOperation = expression.IndexOfAny(new char[] { '+', '-', '*', '/', '^' }); // get index of math operation
                int indexOfEquals = expression.IndexOf('='); // get index of equals

                isCorrectFirstNumber = double.TryParse(expression.Substring(0, indexOfMathOperation), out firstNumber); //get first number after succesful parse // bool double.TryParse(string, out double)

                operation = expression.Substring(indexOfMathOperation, 1); // get math operation

                isCorrectSecondNumber = double.TryParse(expression.Substring(++indexOfMathOperation, (indexOfEquals - indexOfMathOperation)), out secondNumber); //get second number after succesful parse //string string.Substring(int start, int legth)

                if (!isNegative) // if the first character was '-' -> first number * (-1)
                {
                    firstNumber *= -1;
                }

                if (!isCorrectFirstNumber || !isCorrectSecondNumber) // if parse numbers was succesfel continue to calculate
                {
                    Console.WriteLine("wrong format! Try again.\n");
                    return;
                }

                string afterEquals = expression.Substring(++indexOfEquals); // check characters after '='

                if (!string.IsNullOrEmpty(afterEquals)) // if no characters after '=' continue to calculate
                {
                    Console.WriteLine("Try again\n");
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("wrong format! Try again. Exception\n");
            }
        }

        /// <summary>
        /// The method calculates result of user's expression
        /// </summary>
        public static double GetResultOfOperation()
        {
            if (!isCorrectFirstNumber || !isCorrectSecondNumber) //checks first and second numbers after validations
            {
                Console.WriteLine();
            }
            else
            {
                switch (operation)
                {
                    case "+" :
                        Console.WriteLine(result = firstNumber + secondNumber);
                        break;

                    case "-" :
                        Console.WriteLine(result = firstNumber - secondNumber);
                        break;

                    case "*" :
                        Console.WriteLine(result = firstNumber * secondNumber);
                        break;

                    case "/" :
                        Console.WriteLine(result = firstNumber / secondNumber);
                        break;

                    case "^" :
                        Console.WriteLine(result = Math.Pow(firstNumber, secondNumber));
                        break;
                }
            }

            return result;
        }
    }
}
