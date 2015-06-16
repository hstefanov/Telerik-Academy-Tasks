using System;

class SignOfProduct
{
    static void Main()
    {
        Console.WriteLine("Enter 3 real numbers :");
        double[] numbers = new double[3];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }

        int negativeNumbers = 0;

        //count the numbers with sign "-"
        foreach (var num in numbers)
        {
            if (num < 0)
            {
                negativeNumbers++;
            }
            else if (num == 0)
            {
                Console.WriteLine("The product is zero!");
                break;
            }
        }

        if (negativeNumbers % 2 == 0)
        {
            Console.WriteLine("The product is Positive!");
        }
        else
        {
            Console.WriteLine("The product is Negative!");
        }
    }
}

