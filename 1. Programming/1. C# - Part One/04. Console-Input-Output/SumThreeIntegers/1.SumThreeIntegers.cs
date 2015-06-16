using System;

class SumThreeIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter first integer :");
        int firstNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second integer :");
        int secondNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third integer :");
        int thirdNum = int.Parse(Console.ReadLine());

        int sum = 0;
        sum = firstNum + secondNum + thirdNum;
        Console.WriteLine("The sum of {0}, {1} and {2} is : {3} ",firstNum,secondNum,thirdNum,sum);
    }
}

