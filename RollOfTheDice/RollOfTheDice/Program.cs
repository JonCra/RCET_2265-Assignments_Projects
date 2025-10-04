using System.Security.Cryptography;
/*
    Jonas Cram
    RCET 2265
    Fall 2025
    Robotics and Comm. Sys. Engineering Tech.
    https://github.com/JonCra/RCET_2265-Assignments_Projects
*/
namespace RollOfTheDice
{    
    internal class Program
    {
        private static int rollOneValue;
        private static int rollTwoValue;
        static void Main(string[] args)
        {
            //Console.WriteLine("Roll of the Dice");
            Display();
            Console.ReadLine();
        }
        static int DiceRollerOne()
        {
            //Rolls First 1d6
            Random rollTwo = new Random();
            switch (rollTwo.Next(1, 7))
            {
                case 1:
                    rollTwo.Next(1);
                    rollOneValue = 1;
                    break;
                case 2:
                    rollTwo.Next(2);
                    rollOneValue = 2;
                    break;
                case 3:
                    rollTwo.Next(3);
                    rollOneValue = 3;
                    break;
                case 4:
                    rollTwo.Next(4);
                    rollOneValue = 4;
                    break;
                case 5:
                    rollTwo.Next(5);
                    rollOneValue = 5;
                    break;
                case 6:
                    rollTwo.Next(6);
                    rollOneValue = 6;
                    break;
                default:
                    Console.WriteLine("out of bounds");
                    break;
            }
            return rollOneValue;
        }
        static int DiceRollerTwo()
        {           
            //Rolls Second 1d6
            Random rollOne = new Random();
            switch (rollOne.Next(1, 7))
            {
                case 1:
                    rollOne.Next(1);
                    rollTwoValue = 1;
                    break;
                case 2:
                    rollOne.Next(2);
                    rollTwoValue = 2;
                    break;
                case 3:
                    rollOne.Next(3);
                    rollTwoValue = 3;
                    break;
                case 4:
                    rollOne.Next(4);
                    rollTwoValue = 4;
                    break;
                case 5:
                    rollOne.Next(5);
                    rollTwoValue = 5;
                    break;
                case 6:
                    rollOne.Next(6);
                    rollTwoValue = 6;
                    break;
                default:
                    Console.WriteLine("out of bounds");
                    break;                                               
            }
            return rollTwoValue;            
        }
        static void DiceTally()
        {
            //Initialize results array and local variables
            int[] results = new int[13];
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
            for (int i = 0; i < 1000; i++)
            {
                DiceRollerOne();
                DiceRollerTwo();
                int rollResults = rollOneValue + rollTwoValue;
                if (rollResults == 2)
                {
                    sum2++;
                }
                else if (rollResults == 3)
                {
                    sum3++;
                }
                else if (rollResults == 4)
                {
                    sum4++;
                }
                else if (rollResults == 5)
                {
                    sum5++;
                }
                else if (rollResults == 6)
                {
                    sum6++;
                }
                else if (rollResults == 7)
                {
                    sum7++;
                }
                else if (rollResults == 8)
                {
                    sum8++;
                }
                else if (rollResults == 9)
                {
                    sum9++;
                }
                else if (rollResults == 10)
                {
                    sum10++;
                }
                else if (rollResults == 11)
                {
                    sum11++;
                }
                else if (rollResults == 12)
                {
                    sum12++;
                }
            }
            //Index results into 1-D array
            results[2] = sum2;
            results[3] = sum3;
            results[4] = sum4;
            results[5] = sum5;
            results[6] = sum6;
            results[7] = sum7;
            results[8] = sum8;
            results[9] = sum9;
            results[10] = sum10;
            results[11] = sum11;
            results[12] = sum12;

            int padding = 3;
            for (int i = 2; i < 13; i++)
            {
                Console.Write((results[i]).ToString().PadLeft(padding) + "| ");
            }
        }
        static void Display()
        {
            int[] results = new int[13];
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
            Console.WriteLine("\n" + otherDivider);

            //Write the roll results
            DiceTally();
        }
    }
}