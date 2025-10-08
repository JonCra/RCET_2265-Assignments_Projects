/*
   Jonas Cram
   RCET 2265
   Fall 2025
   Robotics and Comm. Sys. Engineering Tech.
   https://github.com/JonCra/RCET_2265-Assignments_Projects.git
*/
namespace ShuffleTheDeck
{
    /*
     TODO:
        [ ] Create a 52 card deck to draw from
        [ ] The card should be a random suit (spades, clubs, hearts, diamonds) and value (2-10, J, Q, K, A).
        [ ] Use a multidimensional array to track if the card has already been dealt. If so, draw another random card.
        [ ] Shuffle the deck when there are no more cards left or anytime the user chooses.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            bool userQuit = false;
            int count = 0;

            do
            {
                Display();
                Console.WriteLine($"The count is {count}");
                userInput = Console.ReadLine();

                if (userInput == "q" || userInput == "Q")
                {
                    Console.WriteLine("Have a nice day!");
                    Console.ReadLine();
                    userQuit = true;
                }
                else if (userInput == "c" || userInput == "C")
                {
                    //Restart
                    NewDeck();
                    count = 0;
                    userQuit = false;
                }
                else
                {
                    if (count >= 75)
                    {
                        Console.WriteLine("All cards have been drawn.\n" +
                            "Press Q to quit or C to start again.");
                        userInput = Console.ReadLine();
                        if (userInput == "Q" ||  userInput == "q")
                        {
                            userQuit = true;
                            break;
                        }
                        else if (userInput == "c" || userInput == "C")
                        {
                            NewDeck();
                            count = 0;
                            userQuit= false;
                        }
                    }
                }


            }while (userQuit == false);
        }
        static void Display()
        {

        }
        static void DrawCard()
        {

        }
        static void NewDeck()
        {

        }
    }
}
