using System;

class CompareFloatingPointNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number to compare :");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number to compare :");
        float secondNumber = float.Parse(Console.ReadLine());
        float precision = 0.000001f;
        bool equalNumbers = Math.Abs(firstNumber - secondNumber) < precision;
        Console.WriteLine("Are number {0} and {1} equal? : {2}",firstNumber,secondNumber,equalNumbers);
    }
}

