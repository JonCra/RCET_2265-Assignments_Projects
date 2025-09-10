using System.Globalization;

namespace SayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO Enter repo URL here

            string userName = "";
            string userInput = "";

            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();

            do
            {


                if (userName == "Joe")
                {
                    Console.WriteLine("Howdy, Joe! How's Susie?");
                }
                else if (userName == "Emily")
                {
                    Console.WriteLine("Hi, Emily! How's the dogs?");
                }
                else if (userName == "Jonas")
                {
                    Console.WriteLine("Hey, Jonas! C# is fun, isn't it?");
                }
                else if (userName == "Tim" || userName == "Timothy")
                {
                    Console.WriteLine("Hello, Tim! Thinking about giving me an A for this assignment? :D");
                }
                else
                {
                    Console.WriteLine($"Hello, {userName}");
                }
            } while (userInput != "q");
            

        }
    }
}
