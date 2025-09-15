//
//Jonas Cram
//RCET 2265
//Fall 2025
//Robotics and Comm. Sys. Engineering Tech.
//TODO: Add GitHub URL

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            int y = 12;


            for (x = 1; x < 13; x++)
            {
                for (y = 1; y < 13; y++)
                {
                    Console.Write((x * y).ToString().PadLeft(3) + " | ");

                }
                Console.WriteLine();
            }
        }
    }
}
