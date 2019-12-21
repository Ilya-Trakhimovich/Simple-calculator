using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! You are in Simple_Calculator app. Lets start!\n");

            bool flag = true; // variable to create an infinite loop in "while." Is used in the first "while" and chanches in "case 4" 

            while(flag)
            {
                InputData.EnterTheFirstNumber();

                InputData.EnterTheSecondNumber();

                InputData.EnterMathOperation();

                Result.GetResultOfMathOperation(InputData.mathOperation);

                bool flag2 = true; // variable to create an infinite loop in "while." Is used in the second "while" and "case 1", "case 4" 

                while (flag2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                    Console.WriteLine($" 1 - start from begin\n 2 - repeat previous operation\n 3 - show 5 latest results\n 4 - enter expresion in one line\n 5 - exit\n");

                    Console.ResetColor();

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1" :
                            Actions.StartFromBegin();

                            flag2 = false;

                            Console.WriteLine("Ok! Start again.\n");
                            break;

                        case "2" :
                            Actions.SaveOperation();
                            break;

                        case "3" :
                            Result.Show();
                            break;

                        case "4" :
                            OneLine.EnterExpression();
                            OneLine.ValidationInputData();
                            double res = OneLine.GetResultOfOperation();
                            Result.AddResult(res);
                            break;

                        case "5" :
                            flag = Actions.Exit();
                            flag2 = false;
                            break;

                        default :
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("\nTry again!\n");

                            Console.ResetColor();
                            break;
                    }
                }
            }
        }
    }
}
