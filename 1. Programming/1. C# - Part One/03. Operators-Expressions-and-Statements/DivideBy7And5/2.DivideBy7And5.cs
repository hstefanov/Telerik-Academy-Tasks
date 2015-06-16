using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Enter number to check:");
        int num = int.Parse(Console.ReadLine());

        bool canBeDivided = false;
        if (num % 5 == 0 && num % 7 == 0)
        {
            canBeDivided = true;
        }
        Console.WriteLine("If {0} can be divided by 7 and 5 in the same time : {1}",num,canBeDivided);

    }
}

