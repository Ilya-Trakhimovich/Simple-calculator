using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public static class Result
    {
        /// <summary>
        /// Counter for results
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// Result of math operation
        /// </summary>
        private static double result;
        
        /// <summary>
        /// List to save results. 
        /// </summary>
        private static double[] arrayOfResults = new double[5];

        /// <summary>
        /// the method get a result of math operation.
        /// </summary>
        /// <param name="opertion">Math operation</param>
        /// <returns></returns>
        public static double GetResultOfMathOperation(string operation)
        {
            switch (operation)
            {
                case "+":
                    {
                        result = InputData.firstNumber + InputData.secondNumber;

                        Console.WriteLine($"{InputData.firstNumber} + {InputData.secondNumber} = {result}\n");

                        break;
                    }
                case "-":
                    {
                        result = InputData.firstNumber - InputData.secondNumber;

                        Console.WriteLine($"{InputData.firstNumber} - {InputData.secondNumber} = {result}\n");

                        break;
                    }
                case "*":
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

            SaveResult(result);

            return result;
        }

        /// <summary>
        /// The method saves 5 last results of math operations.
        /// </summary>
        /// <param name="result"></param>
        private static void SaveResult(double result)
        {
            int times = (int)(count / 5);

            if (count < 5)
            {
                arrayOfResults[count] = result;
            }
            else
            {
                int index = count - times * 5;
                arrayOfResults[index] = result;
            } 
        }

        /// <summary>
        /// The method show 5 last results of last math operations
        /// </summary>
        public static void Show()
        {
            for (int i = 0; i < arrayOfResults.Length; i++)
            {
                Console.WriteLine(arrayOfResults[i]);
            }
        }
    }
}
