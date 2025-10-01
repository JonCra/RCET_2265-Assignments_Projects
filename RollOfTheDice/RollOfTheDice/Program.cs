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

            string vDivider = " |"; //Column Seperator
            int padding = 2;
            int totalWidth =  6 * (padding + vDivider.Length);
            string hDivider = new string('-', totalWidth);  //Dynamic length horizontal divider
            Console.WriteLine(hDivider + " Roll of the Dice " + hDivider);
            for (int roll = 2; roll < 13; roll++)
            {
                //create an array to index the tallies of each roll
                Console.Write((roll).ToString().PadRight(padding) + " | ");                
            }
            Console.WriteLine();
            for (int a = 0; a < 66; a++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
