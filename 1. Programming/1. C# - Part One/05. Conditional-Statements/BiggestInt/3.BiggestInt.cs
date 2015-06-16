using System;

class BiggestInt
{
    static void Main()
    {
        Console.WriteLine("Enter three integer numbers :");
        int[] numbers = new int[3];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number {0} : ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        if ((numbers[0] > numbers[1]) && (numbers[0] > numbers[2]))
        {
            Console.WriteLine("The biggest numbers is {0}",numbers[0]);
        }
        else if ((numbers[1] > numbers[0]) && (numbers[1] > numbers[2]))
        {
            Console.WriteLine("The biggest numbers is {0}", numbers[1]);
        }
        else if ((numbers[2] > numbers[0]) && (numbers[1] > numbers[0]))
        {
            Console.WriteLine("The biggest numbers is {0}", numbers[2]);
        }
    }
}

