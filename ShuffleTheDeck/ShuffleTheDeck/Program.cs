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
        private static bool[,] deck = new bool[13, 4];
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
                    else
                    {
                        DrawCard();
                        count++;
                        userQuit = false;
                    }
                }
                Console.Clear();
            }while (userQuit == false);
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
            int column = 0;
            int row = 0;

            //Draw random ball
            //Check if drawn already
            //Yes: Draw nother
            //No: Success! Mark as drawn
            do
            {
                //Get random column
                column = RandomSuitBetween(0, 4);

                //Get random row
                row = RandomSuitBetween(0, 12);
            } while (deck[row, column] == true);


            bool[,] test = new bool[13, 4];
            test = deck;

            deck[row, column] = true;

        }
        static void NewDeck()
        {
            //Create a local array that has the same type, dimensions, size
            bool[,] empty = new bool[13, 4];
            //Overwrite the tracker array with the default contents of the temp array
            deck = empty;
        }
        static int RandomSuitBetween(int min, int max)
        {
            Random RandomNumber = new Random();
            return RandomNumber.Next(min, max + 1);
        }
        static void Display()
        {
            string currentLocation = "  ";  //show spaces for not drawn, number for drawn
            string[] header = { "B", "I", "N", "G", "O" };  //Bingo header title
            int padding = 3;    //Right justify amount
            string vDivider = " |"; //Column seperator
            int totalWidth = 5 * (padding + vDivider.Length);   //Calculate total width
            string hDivider = new string('-', totalWidth);  //Dynamic length horizontal divider

            //Print header row
            foreach (string letter in header)
            {
                Console.Write(letter.PadLeft(padding) + vDivider);
            }

            //Visual break
            Console.WriteLine();
            //Horizontal divider
            Console.WriteLine(hDivider);

            //Display UI
            for (int row = 0; row < 15; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    if (CardIsDrawn(row, column))
                    {
                        //currentLocation = "00"; //TODO resolve actual number
                        currentLocation = ((column * 15) + row + 1).ToString();
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