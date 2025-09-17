//
//Jonas Cram
//RCET 2265
//Fall 2025
//Robotics and Comm. Sys. Engineering Tech.
//https://github.com/JonCra/RCET_2265-Assignments_Projects/tree/66e17e39bb5b147fb563cd94eab03d19c7985f85/MultiplicationTable

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Acts like an x/y graph, 12 values left/down
            int x = 12;
            int y = 12;

            //Each value starts at 1 and will stop when the iteration is NOT less than 13... i.e: 12
            for (x = 1; x < 13; x++)
            {
                for (y = 1; y < 13; y++)
                {
                    //Multiplies each value together, and "pads" each sequence with 3 spaces and a divider
                    Console.Write((x * y).ToString().PadLeft(3) + " | ");
                }
                //Breaks after each sequence
                Console.WriteLine();
            }
                //Pause
                Console.ReadLine();            
        }
    }
}
