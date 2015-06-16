using System;

class PrintMyAge
{
    static void Main()
    {
        Console.WriteLine("How old are you?");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age after 10 years will be : {0}",age + 10);
    }
}

