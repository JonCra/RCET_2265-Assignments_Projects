//
//Jonas Cram
//RCET 2265
//Fall 2025
//Robotics and Comm. Sys. Engineering Tech.
//https://github.com/JonCra/RCET_2265-Assignments_Projects/tree/3c11c303950eded48c6825826adc3fac8d94586f/FortuneCookie

namespace FortuneCookie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";

            Console.WriteLine("Press 'Enter' to get your fortune!");
            Console.ReadLine();

            while (userInput != "q")
            {                
                Random roll = new Random();
                for (int i = 0; i < 1; i++)
                {
                    //sets the roll parameters (min, max)
                    switch (roll.Next(0, 6))
                    {
                        case 0:
                            {
                                fortuneZero();
                                break;
                            }
                        case 1:
                            {
                                fortuneOne();
                                break;
                            }
                        case 2:
                            {
                                fortuneTwo();
                                break;
                            }
                        case 3:
                            {
                                fortuneThree();
                                break;
                            }
                        case 4:
                            {
                                fortuneFour();
                                break;
                            }
                        case 5:
                            {
                                fortuneFive();
                                break;
                            }
                    }
                }

                Console.WriteLine("Press 'Enter' to get another fortune or press 'q' to exit.");
                userInput = Console.ReadLine();

            }
                        
        EndProgram:
            Console.WriteLine();
        }

        static void fortuneZero()
        {
            Console.WriteLine("Fortune 1/6:\nYou will (obscure action even) in the future.\n");
        }

        static void fortuneOne()
        {
            Console.WriteLine("Fortune 2/6:\nError 404: File 'Fortune_Cookie.exe' not found.\n");
        }

        static void fortuneTwo()
        {
            Console.WriteLine("Fortune 3/6:\nA candle loses nothing by lighting another candle.\n");
        }

        static void fortuneThree()
        {
            Console.WriteLine("Fortune 4/6:\nEvery exit is an entrance to new experiences.\n");
        }

        static void fortuneFour()
        {
            Console.WriteLine("Fortune 5/6:\nThe best revenge is to not be like your enemy.\n");
        }

        static void fortuneFive()
        {
            Console.WriteLine("Fortune 6/6:\nYou will soon witness a miracle in the form of a paycheck.\n");
        }                
    }
}
