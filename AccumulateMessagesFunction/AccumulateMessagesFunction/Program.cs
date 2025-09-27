/*
    Jonas Cram
    RCET 2265
    Fall 2025
    Robotics and Comm. Sys. Engineering Tech.
    https://github.com/JonCra/RCET_2265-Assignments_Projects.git
 */

namespace AccumulateMessagesFunction
{
    /*
    TODO:
        Define a function that takes a string message and appends it to an accumulating result (e.g., a log or transcript).
        Allow the user to enter multiple messages, accumulating them until the user chooses to stop.
        Display the accumulated messages at the end.
        Wait for the user to press Enter before closing the console window.
    */
    internal class Program
    {
        private static string _messages = "";
        static void Main(string[] args)
        {
            MessagesManual();
        }
        static void MessagesManual()
        {
            string userMessage = "this is important";
            bool userHasQuit = false;
            do
            {
                Console.WriteLine("Press 'q' or 'Q' any time to quit.\n" +
                    "Enter a message:\n");
                userMessage = Console.ReadLine();
                if (userMessage == "q" || userMessage == "Q")
                {
                    userHasQuit = true;
                }
                else if (userMessage == "m" || userMessage == "M")
                {
                    Console.Clear();
                    Console.WriteLine("The Messages are:\n\n" + Messages() + "\n");
                }
                else if (userMessage == "c" || userMessage == "C")
                {
                    //clear all messages
                    Messages("", true);
                    //TODO add clear flag                    
                }
                else
                {
                    Messages(userMessage);
                    Console.Clear();
                }
            } while (userHasQuit == false);

            Console.Clear();
            Console.WriteLine("The messages are:\n\n" + Messages());
            Console.WriteLine("\nPress 'enter' to quit.");
        }
        static string Messages(string currentMessage = "", bool clear = false)
        {
            //removes leading/lagging whitespace
            currentMessage = currentMessage.Trim();

            //Grab the contents of the class level static variable
            string messages = _messages;
            if (clear == true)
            {
                messages = "";
            }
            //test for "", skip if "" - skips blank lines
            else if (messages.Length == 0 && currentMessage != "")//avoid initial blank line
            {
                //append currrent message
                messages += currentMessage;
            }
            else if (currentMessage != "")//skip empty messages
            {
                //Append new line and the current message
                messages += "\n" + currentMessage;
            }

            //Store the updated messages to global
            _messages = messages;

            //Return the messages
            return messages;
        }
        static void TestMessages()
        {
            Messages("Hello!");
            Messages("Bye!");
            Messages("");
            Messages("Punch!");
            Messages("Pie!");
            Messages("Dog!");
            Console.WriteLine(Messages("Pony"));
        }
    }
}
