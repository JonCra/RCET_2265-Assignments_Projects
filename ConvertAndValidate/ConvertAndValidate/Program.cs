/*
    Jonas Cram
    RCET 2265
    Fall 2025
    Robotics and Comm. Sys. Engineering Tech.
    https://github.com/JonCra/RCET_2265-Assignments_Projects.git
 */
namespace ConvertAndValidate
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            int theNumber = 0;
            string userData = "";
            bool userHasQuit = false;

            do
            {
                Console.WriteLine("Press 'Q' or 'q' to quit.\n" +
                    "Enter a number\n");
                userData = Console.ReadLine();
                if (userData == "q" || userData == "Q")
                {
                    userHasQuit = true;
                }
                else if (userData != "q" || userData != "Q")
                {                    
                    if (ConvertAndValidate(userData, ref theNumber) == true)
                    {
                        Console.WriteLine($"\nConversion successful!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine($"\nERROR: '{userData}' is not a number");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    userHasQuit = false;
                }
            } while (userHasQuit == false);

            //Clear terminal
            Console.Clear();

            //Exit dialogue
            Console.WriteLine("Quit command detected.\n" +
                "Have a nice day.");

            //Pause
            Console.ReadLine();
        }
        static bool ConvertAndValidate(string convertThis, ref int toThat)
        {
            try
            {
                //Try to convert and assign ByRef variable
                toThat = int.Parse(convertThis);
                //Success!
                return true;
            }
            catch (Exception)
            {
                //Fail
                return false;
            }
        }
    }
}
