/*
    Jonas Cram
    RCET 2265
    Fall 2025
    Robotics and Comm. Sys. Engineering Tech.
    https://github.com/JonCra/RCET_2265-Assignments_Projects.git
 */
namespace ConvertAndValidate
{
    /* TODO:
        [ ] Take two arguments: a string value to be converted, and an out integer variable to store the result.
        [ ] Return a boolean indicating if the conversion was successful.
        [ ] If successful, update the out integer variable with the converted value.
        [ ] If not, do not update the integer variable.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int theNumber = 0;
            string userData = "5";

            if (ConvertAndValidate(userData, ref theNumber) == true)
            {
                Console.WriteLine($"{theNumber} + 5 = {theNumber + 5}");
            }
            else
            {
                Console.WriteLine($"'{userData}' is not a number");
            }

            //Pause
            Console.ReadLine();
        }
        static bool ConvertAndValidate(string convertThis, ref int toThisNumber)
        {
            try
            {
                //Try to convert and assign ByRef variable
                toThisNumber = int.Parse(convertThis);
                //Success!
                return true;
            }
            catch (Exception)
            {
                //Fail
                return false;
            }
        }
    }
}
