using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        Console.Write("Number = ");
        int number = int.Parse(Console.ReadLine());

        int temp = number / 100;
        int result = temp % 10;

        if (result == 7)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

