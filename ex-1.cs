using System;

namespace UltimateCMasterclass
{
    public class ex_1
    {
        public static void Run()
        {
            // 2️⃣ User Input & Conversion
            // Ask the user to input their age as a string.
            // Convert the string to an integer.
            // Print a message confirming the conversion.

            Console.WriteLine("Enter your age:");
            string userAgeString = Console.ReadLine();

            // Safely convert the input to an integer
            if (int.TryParse(userAgeString, out int userAgeConverted))
            {
                Console.WriteLine($"Your age is {userAgeConverted}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}