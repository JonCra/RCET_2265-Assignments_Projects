//
//Jonas Cram
//RCET 2265
//Fall 2025
//Robotics and Comm. Sys. Engineering Tech.
//TODO: insert GitHub URL

namespace BetterCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            nint firstNumber = 0;
            nint secondNumber = 0;
            nint result_1 = 0;
            nint result_2 = 0;
            nint result_3 = 0;
            nint result_4 = 0;
            string userInput = "";
            string operationSelect = "";

            do
            {
                Console.Write("Press 'q' to quit at any time.\n" +
                    "Choose a number: ");
                userInput = Console.ReadLine();
                firstNumber = int.Parse(userInput);
                Console.WriteLine($"First number: {firstNumber}\n");

                Console.Write("Choose another number: ");
                userInput = Console.ReadLine();
                secondNumber = int.Parse(userInput);
                Console.WriteLine($"Second number: {secondNumber}\n");

                Console.WriteLine("Select an operation type:\n" +
                    $"1. Add: ({firstNumber} + {secondNumber})\n" +
                    $"2. Subtract: ({firstNumber} - {secondNumber})\n" +
                    $"3. Multiply: ({firstNumber} * {secondNumber})\n" +
                    $"4. Divide: ({firstNumber} / {secondNumber})");
                operationSelect = Console.ReadLine();

                do
                {
                    if (operationSelect == "1")
                    {
                        result_1 = (firstNumber + secondNumber);
                    }
                    else if (operationSelect == "2")
                    {
                        result_2 = (firstNumber - secondNumber);
                    }
                    else if (operationSelect == "3")
                    {
                        result_3 = (firstNumber * secondNumber);
                    }
                    else if (operationSelect == "4")
                    {
                        result_4 = (firstNumber / secondNumber);
                    }
                    else
                    {
                        Console.WriteLine("Error: Please select a valid operation.");
                    }

                } while (userInput != "q");

            } while (userInput != "q");
        }
    }
}
