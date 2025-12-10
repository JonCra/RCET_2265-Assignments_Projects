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
        [X] Create a 52 card deck to draw from
        [ ] The card should be a random suit (spades, clubs, hearts, diamonds) and value (2-10, J, Q, K, A).
        [X] Use a multidimensional array to track if the card has already been dealt. If so, draw another random card.
        [X] Shuffle the deck when there are no more cards left or anytime the user chooses.
     */
    internal class Program
    {
        private static bool[,] deck = new bool[13, 4];
        private static string[] cardValue = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        private static string[] cardSuit = { "Spades", "Clubs", "Hearts", "Diamonds" };
        private static string NameOfCard = "";
        
        static void Main(string[] args)
        {
            Console.Title = "Shuffle the Deck";
            string userInput = "";
            bool userQuit = false;
            int count = 0;

            do
            {
                Display();
                Console.WriteLine($"\nThe count is {count}");
                if (count != 0)
                {
                    Console.WriteLine($"You drew {NameOfCard}");
                }

                userInput = Console.ReadLine();

                if (userInput == "q" || userInput == "Q")
                {
                    // Quit function
                    Console.WriteLine("Have a nice day!");
                    Console.ReadLine();
                    userQuit = true;
                }
                else if (userInput == "c" || userInput == "C")
                {
                    // Restart/clear function
                    NewDeck();
                    count = 0;
                    userQuit = false;
                }
                else
                {
                    if (count == 52)
                    {
                        Console.WriteLine("All cards have been drawn.\n" +
                            "Press Q to quit or C to start again.");
                        userInput = Console.ReadLine();
                        if (userInput == "Q" || userInput == "q")
                        {
                            userQuit = true;
                            break;
                        }
                        else if (userInput == "c" || userInput == "C")
                        {
                            NewDeck();
                            count = 0;
                            userQuit = false;
                        }
                    }
                    else
                    {
                        DrawCard();
                        count++;
                        userQuit = false;
                    }
                }
                // Clears and updates
                Console.Clear();
            } while (!userQuit);
        }
        
        static bool CardIsDrawn(int row, int column)
        {
            bool status = false;
            try
            {
                status = deck[row, column];
            }
            catch (Exception)
            {
                //reading out of bounds of array will crash
                //maybe log exception here...?
            }
            return status;
        }

        static void DrawCard()
        {
            int column;
            int row;
            do
            {
                // Get random column
                column = RandomSuitBetween(0, 3);

                // Get random row
                row = RandomSuitBetween(0, 12);
            } while (deck[row, column] == true);

            // Mark drawn card as true
            deck[row, column] = true;

            string cardName = $"{cardValue[row]} of {cardValue[column]}";
            NameOfCard = cardName;
        }
        
        static void NewDeck()
        {
            // Create a local array that has the same type, dimensions, size
            bool[,] empty = new bool[13, 4];

            // Overwrite the tracker array with the default contents of the temp array
            deck = empty;
        }
        
        static int RandomSuitBetween(int min, int max)
        {
            Random RandomNumber = new Random();
            return RandomNumber.Next(min, max + 1);
        }
        
        static void Display()
        {
            string currentLocation;

            // Column seperator
            string vDivider = " |";
            
            // Right justify amount
            int padding = (cardSuit.Length + vDivider.Length);            

            // Calculate total width
            int totalWidth = 5 * (padding + vDivider.Length);
            
            // Dynamic length horizontal divider
            string hDivider = new string('-', totalWidth);

            for (int i = 0; i < cardSuit.Length; i++)
            {
                Console.Write($"{cardSuit[i]}{vDivider} ");
            }
            Console.WriteLine();            

            // Display card matrix
            for (int row = 0; row < 13; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    if (CardIsDrawn(row, column))
                    {
                        // Show actual card value and suit
                        currentLocation = $"{cardValue[row]}";
                    }
                    else
                    {
                        currentLocation = "  ";
                    }
                    Console.Write(currentLocation.PadLeft(padding) + vDivider);
                }
                Console.WriteLine();
            }
        }
    }
}