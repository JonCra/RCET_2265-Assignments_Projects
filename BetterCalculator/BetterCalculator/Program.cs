//
//Jonas Cram
//RCET 2265
//Fall 2025
//Robotics and Comm. Sys. Engineering Tech.
//https://github.com/JonCra/RCET_2265-Assignments_Projects/tree/627f95ae32452d4a39a08d44a7dbec6ab8228f6f/BetterCalculator

using System.Xml.Schema;

namespace BetterCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = 0;
            decimal secondNumber = 0;
            decimal result_1 = 0;
            decimal result_2 = 0;
            decimal result_3 = 0;
            decimal result_4 = 0;
            string userInput = "";
            string operationSelect = "";
            bool userHasQuit = false;

            do
            {
                //First Number Input
                Console.Write("Press 'Q' to quit at any time.\n" +
                    "Choose a number: ");
                userInput = Console.ReadLine();
                if (userInput != "Q")
                {
                    firstNumber = decimal.Parse(userInput);
                    Console.WriteLine($"First number: {firstNumber}\n");
                    userHasQuit = false;
                }
                else if (userInput == "Q")
                {
                    userHasQuit = true;
                    goto exit_program;
                }

                //Second Number Input
                Console.Write("Choose another number: ");
                userInput = Console.ReadLine();
                if (userInput != "Q")
                {
                    secondNumber = decimal.Parse(userInput);
                    Console.WriteLine($"Second number: {secondNumber}\n");
                    userHasQuit = false;
                }
                else if (userInput == "Q")
                {
                    userHasQuit = true;
                    goto exit_program;
                }

                //Operation Select
                Console.WriteLine("Select an operation type:\n" +
                    $"1. Add: ({firstNumber} + {secondNumber})\n" +
                    $"2. Subtract: ({firstNumber} - {secondNumber})\n" +
                    $"3. Multiply: ({firstNumber} * {secondNumber})\n" +
                    $"4. Divide: ({firstNumber} / {secondNumber})\n");
                operationSelect = Console.ReadLine();
                Console.WriteLine($"Operation selected: '{operationSelect}'\n");

                do
                {

                    if (operationSelect == "1")
                    {
                        result_1 = (firstNumber + secondNumber);
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {result_1}");
                        userInput = Console.ReadLine();
                        userHasQuit = false;
                    }

                    else if (operationSelect == "2")
                    {
                        result_2 = (firstNumber - secondNumber);
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {result_2}");
                        userInput = Console.ReadLine();
                        userHasQuit = false;
                    }

                    else if (operationSelect == "3")
                    {
                        result_3 = (firstNumber * secondNumber);
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {result_3}");
                        userInput = Console.ReadLine();
                        userHasQuit = false;
                    }

                    else if (operationSelect == "4")
                    {
                        result_4 = (firstNumber / secondNumber);
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {result_4}");
                        userInput = Console.ReadLine();
                        userHasQuit = false;
                    }

                    else if (operationSelect == "Q")
                    {
                        userHasQuit = true;
                        goto exit_program;
                    }

                    else
                    {
                        Console.WriteLine("Error: Please select a valid operation.");
                        Console.ReadLine();
                        userHasQuit = false;
                    }

                } while (userHasQuit = false);

            } while (userHasQuit = false);

            exit_program:
                Console.WriteLine("Stop command detected. Have a nice day.\n" +
                "Press 'enter' to close this window.");
                Console.ReadLine();
        }
    }
}
