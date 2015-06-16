using System;

class ExchangeValues
{
    static void Main()
    {
        Console.WriteLine("Enter values for \"a\" and \"b\" :");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a = {0} , b = {1}",a,b);
        }
        else
        {
            Console.WriteLine("b > a");
        }
    }
}

