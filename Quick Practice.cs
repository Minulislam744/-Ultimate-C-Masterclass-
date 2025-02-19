using System;
namespace UltimateCMasterclass
{       
class Program_conversion
{
    
    static void Main()
    {
        int anotherIntValue = 42;
        double anotherDoublevalueManual = (double)anotherIntValue;
        Console.WriteLine($"This is manual conversion: {anotherDoublevalueManual}");

        int test = 10;
        double tesDouble = test;
        Console.WriteLine($"Double to Int: {tesDouble}");

        string testtoInt = "100";
        int toIntConvert = Convert.ToInt32(testtoInt);
        Console.WriteLine($"Converted string to int using class: {toIntConvert}");

        double convertToIntger = 10.33;
        int converted = (int)convertToIntger;

 Console.WriteLine("Enter a number:");
            string num1Input = Console.ReadLine();

            int num1;
            if (!int.TryParse(num1Input, out num1))
            {
                Console.WriteLine("Invalid input for the first number. Please enter a valid integer.");
                return; // Or handle the error differently, like looping to ask again
            }

            Console.WriteLine("Enter another number:");
            string num2Input = Console.ReadLine();

            int num2;
            if (!int.TryParse(num2Input, out num2))
            {
                Console.WriteLine("Invalid input for the second number. Please enter a valid integer.");
                return;
            }

            Console.WriteLine("Enter an operator (+, -, *, /):");
            string op = Console.ReadLine();

            if (string.IsNullOrEmpty(op))
            {
                Console.WriteLine("No operator entered.");
                return;
            }

            switch (op)
            {
                case "+":
                    Console.WriteLine($"The result is: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"The result is: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"The result is: {num1 * num2}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine($"The result is: {num1 / num2}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

    }

}  
}
