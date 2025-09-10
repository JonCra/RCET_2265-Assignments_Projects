//
//Jonas Cram
//RCET 2265
//Fall 2025
//Robotics and Comm. Sys. Engineering Tech.
//https://github.com/JonCra/RCET_2265-Assignments_Projects/blob/2c71ecfa30ad25f0943478affc9552c9f50715ef/SimpleCalculator_v2

using System.Data;

namespace SimpleCalculator_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Text Data
            nint firstNumber = 0;
            nint secondNumber = 0;
            nint result_1 = 0;
            nint result_2 = 0;
            string userInput = "";

            do
            {
                Console.WriteLine("Enter a number");
                userInput = Console.ReadLine();
                firstNumber = int.Parse(userInput);
                Console.WriteLine($"Number 1: {firstNumber}\n"); //Display first entered value


                Console.WriteLine("Enter another number");
                userInput = Console.ReadLine();
                secondNumber = int.Parse(userInput);
                Console.WriteLine($"Number 2: {secondNumber}\n"); //Display second entered value


                //Ask user for operation type
                Console.WriteLine("Select an operation:\n"
                + "1. Sum\n"
                + "2. Product\n");
                
                //Math operation control(s)
                userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    result_1 = firstNumber + secondNumber;
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result_1}");
                }
                else if (userInput == "2")
                {
                    result_2 = firstNumber * secondNumber;
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result_2}");
                }
                else
                {
                    Console.WriteLine("Error. Enter a valid number.");
                }

                Console.WriteLine(); //Add visual break

                Console.WriteLine($"Press 'q' to exit, or 'Enter' to run again");
                userInput = Console.ReadLine();

            } while (userInput != "q");
        }
    }
}