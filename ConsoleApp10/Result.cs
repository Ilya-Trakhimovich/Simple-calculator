using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp10
{
    /// <summary>
    /// The class allows to get results of math operations, 
    /// save it in list and show 5 latest results. 
    /// Contains 3 methods:
    /// get result of math operation
    /// add result in the list
    /// show 5 latest results
    /// </summary>
    public static class Result
    {
        /// <summary>
        /// Counter for results
        /// </summary>
        private static int count;

        /// <summary>
        /// Result of math operation
        /// </summary>
        private static double result;

        /// <summary>
        /// The list contains results of math operations
        /// </summary>
        private static List<double> listOfResults = new List<double>();

        /// <summary>
        /// the method get a result of math operation.
        /// </summary>
        /// <param name="opertion">Math operation</param>
        /// <returns></returns>
        public static void GetResultOfMathOperation(string operation)
        {
            switch (operation)
            {
                case "+" :
                    {
                        result = InputData.firstNumber + InputData.secondNumber;

                        Console.WriteLine($"{InputData.firstNumber} + {InputData.secondNumber} = {result}\n");
                        break;
                    }

                case "-" :
                    {
                        result = InputData.firstNumber - InputData.secondNumber;

                        Console.WriteLine($"{InputData.firstNumber} - {InputData.secondNumber} = {result}\n");
                        break;
                    }
                case "*" :
                    {
                        result = InputData.firstNumber * InputData.secondNumber;

                        Console.WriteLine($"{InputData.firstNumber} * {InputData.secondNumber} = {result}\n");
                        break;
                    }
                case "/":
                    {
                        if (InputData.secondNumber == 0)
                        {
                            Console.WriteLine("Divide by zero is prohibited!\n");
                            break;
                        }
                        result = InputData.firstNumber / InputData.secondNumber;

                        Console.WriteLine($"{InputData.firstNumber} / {InputData.secondNumber} = {result}\n");
                        break;
                    }
                case "^":
                    {
                        result = Math.Pow(InputData.firstNumber, InputData.secondNumber);

                        Console.WriteLine($"{InputData.firstNumber} ^ {InputData.secondNumber} ={result}\n");
                        break;
                    }
            }
            count++;
             
            AddResult(result);
        }       

        /// <summary>
        /// The method add result in the list.
        /// </summary>
        /// <param name="result">result of math operation</param>
        public static void AddResult(double result)
        {
            listOfResults.Add(result);
        }

        /// <summary>
        /// The method shows 5 latest results.
        /// </summary>
        public static void Show()
        {
            Console.WriteLine();

            for (int i = 0; i < listOfResults.Count; i++)
            {
                if (listOfResults.Count < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Write($"{listOfResults[i]} ");

                    Console.ResetColor();
                }
                else
                {
                    int last = listOfResults.Count - 5; //variable for shift counter 5 positions back 

                    while (last != listOfResults.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.Write($"{listOfResults[last]} ");

                        Console.ResetColor();

                        last++;
                    }

                    break;
                }
            }

            Console.WriteLine("\n");
        }
    }
}
