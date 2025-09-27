/*
    Jonas Cram
    RCET 2265
    Fall 2025
    Robotics and Comm. Sys. Engineering Tech.
    https://github.com/JonCra/RCET_2265-Assignments_Projects.git
 */

namespace AccumulateMessagesFunction
{    
    internal class Program
    {
        //"Global" variable that allows User Message/string data to be stored/recalled
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
                    "Press 'f' or 'F' to list available functions.\n\n" + 
                    "Enter a message:\n");
                userMessage = Console.ReadLine();
                if (userMessage == "q" || userMessage == "Q")
                {
                    userHasQuit = true;
                }
                if (userMessage == "f" || userMessage == "F")
                {
                    Console.WriteLine($"Command List:\n" + 
                        "[] 'Q'/'q' - Quit and exit the program\n" +
                        "[] 'M'/'m' - Display stored messages\n" +
                        "[] 'C'/'c' - Clear all stored messages\n");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (userMessage == "m" || userMessage == "M")
                {
                    Console.Clear();
                    Console.WriteLine("The Messages are:\n\n" + Messages() + "\n");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (userMessage == "c" || userMessage == "C")
                {
                    //clear all messages
                    Messages("", true);
                    Console.WriteLine("Messages erased.");
                    Console.ReadLine();
                    Console.Clear();
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

        //User message formatter Method
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
            Messages("");   //Tests if blank message clear function is working
            Messages("Punch!");
            Messages("Pie!");
            Messages("Dog!");
            Console.WriteLine(Messages("GNOMES"));
        }
    }
}
