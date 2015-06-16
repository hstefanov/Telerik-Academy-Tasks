using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter value for side a : ");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for side b : ");
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for side h : ");
        Console.Write("h = ");
        double h = double.Parse(Console.ReadLine());

        double trapezoidArea = ((a + b) / 2) * h;
        Console.WriteLine("Trapezoid area = {0}",trapezoidArea);
    }
}

