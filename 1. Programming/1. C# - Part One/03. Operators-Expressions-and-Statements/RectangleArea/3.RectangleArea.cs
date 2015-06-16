using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter width:");
        Console.Write("Width = ");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter height:");
        Console.Write("Height = ");
        double height = double.Parse(Console.ReadLine());

        double area = width * height;
        Console.WriteLine("Rectangle area is : {0}",area);
    }
}

