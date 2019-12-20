using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ss = Console.ReadLine().Replace(' ', ',');
            //Console.WriteLine(ss);

            Console.WriteLine("Hello! You are in Simple_Calculator app. Lets start!\n");

            bool flag = true;

            while(flag)
            {
                InputData.EnterTheFirstNumber();

                InputData.EnterTheSecondNumber();

                InputData.EnterMathOperation();

                Result.GetResultOfMathOperation(InputData.mathOperation);

                bool flag2 = true;

                while (flag2)
                {
                    Console.WriteLine($" 1 - start from begin\n 2 - repeat previous operation\n 3 - show 5 latest results\n 4 - exit\n");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":

                            Actions.StartFromBegin();

                            flag2 = false;

                            Console.WriteLine("Ok! Start again.\n");

                            break;

                        case "2":

                            Actions.SaveOperation();

                            break;
                        case "3":

                            Result.Show();

                            break;
                        case "4":

                            flag = Actions.Exit();
                            flag2 = false;

                            break;
                        default:

                            Console.WriteLine("\nTry again!\n");

                            break;
                    }
                }
            }
        }
    }
}
