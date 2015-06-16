using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter first number :");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number :");
        int secondNum = int.Parse(Console.ReadLine());

        int greaterNum = Math.Max(firstNum, secondNum);
        Console.WriteLine("Greater number between {0} and {1} is {2} ",firstNum,secondNum,greaterNum);
    }
}

