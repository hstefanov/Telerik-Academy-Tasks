using System;

class NumbersDivideByFive
{
    static void Main()
    {
        Console.WriteLine("Enter first integer value : ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second integer value :");
        int secondNum = int.Parse(Console.ReadLine());

        int counter = 0;
        for (int i = firstNum; i <= secondNum; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine("Numbers between p({0},{1}) divisible by 5 are : {2}",firstNum,secondNum,counter);
    }
}

