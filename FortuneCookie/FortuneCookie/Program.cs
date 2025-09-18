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
            for (int i = 0; i < 100; i ++)
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
            Console.WriteLine("1) Yesterday is history, tomorrow is a mystery, but today is a gift..."
                + "\n   That is why it is called the Present.\n");
        }

        static void fortuneOne()
        {
            Console.WriteLine("2) If a situation is out of your hands, why is it in your head?\n");
        }

        static void fortuneTwo()
        {
            Console.WriteLine("3) A candle loses nothing by lighting another candle.\n");
        }

        static void fortuneThree()
        {
            Console.WriteLine("4) You can't control the wind, but you can adjust your sails.\n");
        }

        static void fortuneFour()
        {
            Console.WriteLine("5) The best revenge is to not be like your enemy.\n");
        }

        static void fortuneFive()
        {
            Console.WriteLine("6) Today is a good day to \n");
        }                
    }
}
