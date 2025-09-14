using System.Globalization;

namespace SayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            //Jonas Cram
            //RCET 2265
            //Fall 2025
            //Robotics and Comm. Sys. Engineering Tech.
            //TODO: https://github.com/JonCra/RCET_2265-Assignments_Projects/tree/fa0ea4834dc3d16e1c302b91000ba961daeb470c/SayMyNameAgain

            string userName = "";
            string timInput = "";

            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();

            
                Console.WriteLine();
                if (userName == "Joe" || userName == "joe")
                {
                    Console.WriteLine("Howdy, Joe! How's Susie?");
                    Console.ReadLine();
                }
                else if (userName == "Emily" || userName == "emily")
                {
                    Console.WriteLine("Hi, Emily! How's the dogs?");
                    Console.ReadLine();
                }
                else if (userName == "Jonas" || userName == "jonas")
                {
                    Console.WriteLine("Hey, Jonas! C# is fun, isn't it?");
                    Console.ReadLine();
                }
                else if (userName == "Tim" || userName == "tim")
                {
                    Console.Write("Heyyyy, Tim! Wanna give me an A for this assignment?\n" +
                        "y/n\n");

                    timInput = Console.ReadLine();
                    if (timInput == "y")
                    {
                        Console.WriteLine("YEEEESSSSSS :D");
                        Console.ReadLine();
                    }
                    else if (timInput == "n")
                    {
                        Console.WriteLine("Ehhh... worth a shot ;-;");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"You chose poorly...\n\n" +
                            "Deleting files\n" +
                            "C:/Windows/system32...");
                        Console.ReadLine();
                    }
                    Console.WriteLine();

                }

                else
                {
                    Console.WriteLine($"Hello, {userName}.");
                    Console.ReadLine();
                }
                } 
            } 
        }
