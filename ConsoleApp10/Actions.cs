using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public static class Actions
    {
        //private static bool isCorect;

        /// <summary>
        /// The method saves previous math operation
        /// </summary>
        public static void SaveOperation()
        {
                InputData.EnterTheFirstNumber();
                InputData.EnterTheSecondNumber();

                Console.WriteLine($"Math operation: {InputData.mathOperation}");

                Result.GetResultOfMathOperation(InputData.mathOperation);
        }

        /// <summary>
        /// The method allows to start calculate from begin. Doesnt delete previous results.
        /// </summary>
        public static void StartFromBegin()
        {
            InputData.firstNumber = default;
            InputData.secondNumber = default;
            InputData.mathOperation = default;

            Console.Clear();       
        }

        /// <summary>
        /// The method allows to exit from app.
        /// </summary>
        /// <returns></returns>
        public static bool Exit()
        {
            //Environment.Exit(0);
            return false;
        }
    }
}

