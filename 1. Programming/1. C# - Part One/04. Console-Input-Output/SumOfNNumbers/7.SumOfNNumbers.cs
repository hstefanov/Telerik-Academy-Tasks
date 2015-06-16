using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers do you want to sum : ");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number {0} : ", i);
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum is : {0}",sum);
    }
}

