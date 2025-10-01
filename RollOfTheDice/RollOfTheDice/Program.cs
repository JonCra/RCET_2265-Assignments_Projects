using System.Security.Cryptography;

namespace RollOfTheDice
{
    /*
     TODO:
        [ ] Display the results in the console in formatted columns with headers.
        [ ] The header row should show the roll result numbers 2 to 12 (2d6).
        [ ] The data row should show the total count of how many times each number came up.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Roll of the Dice");
            Display();
            Console.ReadLine();
        }
        static void DiceRoller()
        {
            Console.WriteLine("*Rolls die*");
            //Roll two 1d6 Die
            //tally the total sum of each roll
        }
        static void Display()
        {
            //TODO
            //Format results in a "table" - Make it look good
                //Try using something similar to the Bingo Cage???
            //Display results
                //Display rolls 2-12
                //Display roll results

            int padding = 3;
            int totalWidth =  6 * (padding);
            string hDivider = new string('-', totalWidth);
            string otherDivider = new string('-', (totalWidth * 3));
            Console.WriteLine(hDivider + " Roll of the Dice " + hDivider);
            for (int roll = 2; roll < 13; roll++)
            {
                Console.Write((roll).ToString().PadLeft(padding) + "| ");                
            }
                //create an array to index the tallies of each roll?
            Console.WriteLine("\n" + otherDivider);
            //Write the roll results
            DiceRoller();
        }
    }
}
