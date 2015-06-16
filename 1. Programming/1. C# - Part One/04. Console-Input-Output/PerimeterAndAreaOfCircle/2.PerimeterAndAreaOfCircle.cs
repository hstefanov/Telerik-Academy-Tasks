using System;

class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        Console.WriteLine("Enter radius \"r\" of the circle :");
        double r = double.Parse(Console.ReadLine());

        double perimeter = 2 * r * Math.PI;
        double area = Math.Pow(r, 2) * Math.PI;
        Console.WriteLine("Perimeter = {0:0.00}", perimeter);
        Console.WriteLine("Area = {0:0.00}", area);
    }
}

