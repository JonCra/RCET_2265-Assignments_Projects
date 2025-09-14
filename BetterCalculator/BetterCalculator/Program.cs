//
//Jonas Cram
//RCET 2265
//Fall 2025
//Robotics and Comm. Sys. Engineering Tech.
//TODO: insert GitHub URL

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
            
            do
            {
                //First Number Input
                Console.Write("Press 'q' to quit at any time.\n" +
                    "Choose a number: ");
                userInput = Console.ReadLine();
                firstNumber = decimal.Parse(userInput);
                Console.WriteLine($"First number: {firstNumber}\n");

                //Second Number Input
                Console.Write("Choose another number: ");
                userInput = Console.ReadLine();
                secondNumber = decimal.Parse(userInput);
                Console.WriteLine($"Second number: {secondNumber}\n");

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
                        operationSelect = "q";
                    }

                    else if (operationSelect == "2")
                    {
                        result_2 = (firstNumber - secondNumber);
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {result_2}");
                        userInput = Console.ReadLine();
                        operationSelect = "q";
                    }

                    else if (operationSelect == "3")
                    {
                        result_3 = (firstNumber * secondNumber);
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {result_3}");
                        userInput = Console.ReadLine();
                        operationSelect = "q";
                    }

                    else if (operationSelect == "4")
                    {
                        result_4 = (firstNumber / secondNumber);
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {result_4}");
                        userInput = Console.ReadLine();
                        operationSelect = "q";
                    }

                    else
                    {
                        Console.WriteLine("Error: Please select a valid operation.");
                        Console.ReadLine();
                        operationSelect = "q";
                    }

                } while (operationSelect != "q");
                                    
            } while (userInput != "q");

            Console.WriteLine("Stop command detected. Have a nice day.\n" +
                "Press 'enter' to close this window.");
            Console.ReadLine();
        }
    }
}
