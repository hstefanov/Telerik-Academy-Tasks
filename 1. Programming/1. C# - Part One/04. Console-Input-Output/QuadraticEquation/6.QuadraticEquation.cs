using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter coefficients for the quadratic equation :");
        Console.Write("Enter a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c = ");
        double c = double.Parse(Console.ReadLine());

        double d = Math.Pow(b, 2) - (4 * a * c);
        if (d < 0)
        {
            Console.WriteLine("Equation do not have real roots");
        }
        else if (d == 0)
        {
            Console.WriteLine("Equation has only one real root : ");
            double x = -b / (2 * a);
            Console.Write(x);
        }
        else
        {
            d = Math.Sqrt(d);
            double x1 = (-b + d) / (2 * a);
            double x2 = (-b - d) / (2 * a);
            Console.WriteLine("Equation have 2 real roots \nX1 = {0:0.000} and X2 = {1:0.000}", x1, x2);
        }
    }
}

