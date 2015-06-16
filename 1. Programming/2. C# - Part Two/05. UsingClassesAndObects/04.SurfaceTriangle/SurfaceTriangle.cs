using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write methods that calculate the surface of a triangle by given:
/// - Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
/// </summary>

class SurfaceTriangle
{
    private static double GetSurfaceAltitude(double a, double h)
    {
        return(a * h) / 2;
    }

    private static double GetSurfaceHeron(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    private static double GetSurfaceAngel(double a, double b, double alpha)
    {
        return (a * b * Math.Sign(Math.PI * alpha / 180)) / 2;
    }

    static void Main()
    {
        Console.WriteLine(GetSurfaceAltitude(3,4));
        Console.WriteLine(GetSurfaceHeron(3,4,5));
        Console.WriteLine(GetSurfaceAngel(3,4,90));
    }
}
