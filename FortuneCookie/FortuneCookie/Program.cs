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
            Random roll = new Random();            
            for (int i = 0; i < 1; i ++)
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
            Console.WriteLine("Press 'Enter' to exit.");
                //Pause
                Console.ReadLine();
        }

        static void fortuneZero()
        {
            Console.WriteLine("1) You will (obscure action even) in the future.\n");
        }

        static void fortuneOne()
        {
            Console.WriteLine("2) Error 404: File 'Fortune_Cookie.exe' not found.\n");
        }

        static void fortuneTwo()
        {
            Console.WriteLine("3) A candle loses nothing by lighting another candle.\n");
        }

        static void fortuneThree()
        {
            Console.WriteLine("4) Every exit is an entrance to new experiences.\n");
        }

        static void fortuneFour()
        {
            Console.WriteLine("5) The best revenge is to not be like your enemy.\n");
        }

        static void fortuneFive()
        {
            Console.WriteLine("6) You will soon witness a miracle in the form of a paycheck.\n");
        }                
    }
}
