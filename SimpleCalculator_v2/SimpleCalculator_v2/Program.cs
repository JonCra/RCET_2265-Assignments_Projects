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
            string operationSelect = "";
            string userInput = "";

            do
            {
                Console.WriteLine("Enter a number");
                firstNumber = Console.ReadLine();
                Console.WriteLine($"Number 1: {firstNumber}"); //Display first entered value

                Console.WriteLine(); //Add visual break

                Console.WriteLine("Enter another number");
                secondNumber = Console.ReadLine();
                Console.WriteLine($"Number 2: {secondNumber}"); //Display second entered value

                Console.WriteLine(); //Add visual break

                //Ask user for operation type
                Console.WriteLine("Select an operation:\n"
                + "1. Sum\n"
                + "2. Product"); //'\n' acts like a carriage return

                //TODO: Error is a conversion type... It's formatted as a string, but needs to be a numerical "base". Fix it.
                result_1 = (firstNumber * secondNumber);
                result_2 = (firstNumber + secondNumber);                

                Console.WriteLine(); //Add visual break

                //Math operation control(s)
                operationSelect = Console.ReadLine();
                if (operationSelect == "1")
                {
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result_1}");
                }
                else if (operationSelect == "2")
                {
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result_2}");
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