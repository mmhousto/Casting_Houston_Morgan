using System;

namespace Casting_Houston_Morgan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user to enter a whole number and assigns input to integer
            Console.WriteLine("Please enter a whole number!");
            int myFavNum = Convert.ToInt32(Console.ReadLine());

            // Prints favorite number to console
            Console.WriteLine("Your favorite number is " + myFavNum);

            // Asks user a true/false question and assigns response to a boolean
            Console.WriteLine("Do you like video games? (Please enter 'true' or 'false')");
            bool isTrue = Convert.ToBoolean(Console.ReadLine());

            // Print the result of question asked
            Console.WriteLine($"It is {isTrue} that I like video games!");

        }
    }
}
