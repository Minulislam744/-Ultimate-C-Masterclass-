using System;

namespace UltimateCMasterclass
{
    class NamePrinter1 // Renamed from Program to NamePrinter
    {
        static void PrintName()
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Binary of {num1}: {Convert.ToString(num1, 2)}");
            Console.WriteLine($"Binary of {num2}: {Convert.ToString(num2, 2)}");

            int andResult = num1 & num2;
            int orResult = num1 | num2;
            int xorResult = num1 ^ num2;
            int leftShiftResult = num1 << 1;
            int rightShiftResult = num1 >> 1;

            Console.WriteLine($"AND: {Convert.ToString(andResult, 2)} (Decimal: {andResult})");
            Console.WriteLine($"OR: {Convert.ToString(orResult, 2)} (Decimal: {orResult})");
            Console.WriteLine($"XOR: {Convert.ToString(xorResult, 2)} (Decimal: {xorResult})");
            Console.WriteLine($"Left Shift: {Convert.ToString(leftShiftResult, 2)} (Decimal: {leftShiftResult})");
            Console.WriteLine($"Right Shift: {Convert.ToString(rightShiftResult, 2)} (Decimal: {rightShiftResult})");
        }
    }
}

