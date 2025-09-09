//Jonas Cram
//RCET 2265
//Fall 2025
//Robotics and Comm. Sys. Engineering Tech.
//https://github.com/JonCra/SayMyName.git

namespace SayMyName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks user for their name
            Console.WriteLine("What is your name?");

            //Reads user's name
            Console.WriteLine(${ Console.WriteLine()} "Your name is {Console.ReadLine()}.");

            //Adds visual gap
            Console.WriteLine();

            //Tells user how to exit program
            Console.WriteLine("Press 'Enter' to quit");

            //Used as a "pause" before exiting program
            Console.ReadLine();
        }
    }
}
