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
            int roll1 = 0;
            int roll2 = 0;
            int roll3 = 0;
            int roll4 = 0;
            int roll5 = 0;
            int roll6 = 0;
            int roll7 = 0;
            int roll8 = 0;
            int roll9 = 0;
            int roll10 = 0;
            int roll11 = 0;
            int roll12 = 0;

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;
            int sum6 = 0;
            int sum7 = 0;
            int sum8 = 0;
            int sum9 = 0;
            int sum10 = 0;
            int sum11 = 0;
            int sum12 = 0;

            for (int i = 0; i < 10; i++)
            {
                //Rolls First 1d6
                Random rollOne = new Random();
                switch (rollOne.Next(1, 6))
                {
                    case 1:
                        rollOne.Next(1);
                        sum1++;
                        break;
                    case 2:
                        rollOne.Next(2);
                        sum2++;
                        break;
                    case 3:
                        rollOne.Next(3);
                        sum3++;
                        break;
                    case 4:
                        rollOne.Next(4);
                        sum4++;
                        break;
                    case 5:
                        rollOne.Next(5);
                        sum5++;
                        break;
                    case 6:
                        rollOne.Next(6);
                        sum6++;
                        break;
                    default:
                        Console.WriteLine("out of bounds");
                        break;
                }
                //Rolls Second 1d6
                Random rollTwo = new Random();
                switch (rollTwo.Next(1, 6))
                {
                    case 1:
                        rollTwo.Next(1);
                        sum1++;
                        break;
                    case 2:
                        rollTwo.Next(2);
                        sum2++;
                        break;
                    case 3:
                        rollTwo.Next(3);
                        sum3++;
                        break;
                    case 4:
                        rollTwo.Next(4);
                        sum4++;
                        break;
                    case 5:
                        rollTwo.Next(5);
                        sum5++;
                        break;
                    case 6:
                        rollTwo.Next(6);
                        sum6++;
                        break;
                    default:
                        Console.WriteLine("out of bounds");
                        break;
                }
                if (rollOne + rollTwo == 2)
                {

                }
            }
            //BUG: Does not tally sums correctly
            Console.WriteLine($"{sum1} + {sum2} + {sum3} + {sum4} + {sum5} + {sum6} + {sum7} + {sum8} + {sum9} + {sum10} + {sum11} + {sum12}");

            //tally the total sum of each roll

            Console.WriteLine("*Rolls die*");            
        }
        static void Display()
        {
            //TODO
            //Format results in a "table" - Make it look good
            //Try using something similar to the Bingo Cage???
            //Display rolls 2-12
            //Display roll results

            string header = "Roll of the Dice";
            int padding = 3;
            int totalWidth =  6 * (padding);
            string hDivider = new string('-', totalWidth);
            string otherDivider = new string('-', (totalWidth * 3));
            Console.WriteLine(header.PadLeft(35));
            Console.WriteLine(hDivider + hDivider + hDivider);
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
