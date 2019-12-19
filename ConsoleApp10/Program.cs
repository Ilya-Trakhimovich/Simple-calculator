using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                InputData.EnterTheFirstNumber();

                InputData.EnterTheSecondNumber();

                InputData.EnterMathOperation();

                Result.GetResultOfMathOperation(InputData.mathOperation);

                Console.WriteLine($" 1 - start from begin\n 2 - repeat previous operation\n 3 - show 5 last results\n 4 - exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Actions.StartFromBegin();
                        break;
                    case "2":
                        Actions.SaveOperation();
                        break;
                    case"3":
                        Result.Show();
                        break;
                    case "4":
                        flag = Actions.Exit();
                        break;
                    default:                        
                        break;
                }
            }
        }
    }
}
