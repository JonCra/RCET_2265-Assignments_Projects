//Jonas Cram
//RCET 2265
//Fall 2025
//Robotics and Comm. Sys. Engineering Tech.
//TODO: add GitHub URL

using System.Data;

namespace SimpleCalculator_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Text Data
            nint firstNumber;
            nint secondNumber;
            nint result_1;
            nint result_2;
            nint operationSelect;


            Console.WriteLine("Enter a number.");
            firstNumber = Console.ReadLine();
            //Display first entered value
            Console.WriteLine($"Number 1: {firstNumber}");


            //Add visual break
            Console.WriteLine();


            Console.WriteLine("Enter another number.");
            secondNumber = Console.ReadLine();
            //Display second entered value
            Console.WriteLine($"Number 2: {secondNumber}");




            //Add visual break
            Console.WriteLine();

            //Ask user for operation type
            Console.WriteLine("Select Operation:");
            Console.WriteLine($"1. Product ({firstNumber} * {secondNumber})");
            Console.WriteLine($"2. Sum ({firstNumber} + {secondNumber})");

            //TODO: Error is a conversion type... It's formatted as a string, but needs to be a numerical "base". Fix it.
            result_1 = firstNumber * secondNumber;
            Console.WriteLine($"{firstNumber} * {secondNumber} = {result_1}");

            result_2 = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {result_2}");


            operationSelect = Console.ReadLine();

            if (operationSelect == 1)
            {
                Console.WriteLine(result_1);
            }

            else if (operationSelect == 2)
            {
                Console.WriteLine(result_2);
            }

            else (operationSelect < 1 || 2 <)
            {
                Console.WriteLine("Error. Please enter a valid number.");
            }


            //Add visual break
            Console.WriteLine();

            //Add delay
            Console.WriteLine("Press 'Enter' to exit");
            Console.ReadLine();

        }
    }
}
