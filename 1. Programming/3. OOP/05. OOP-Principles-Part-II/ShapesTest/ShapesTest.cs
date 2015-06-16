/*
01.Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
(height*width for rectangle and height*width/2 for triangle).
Define class Circle and suitable constructor so that at initialization height must be kept equal to width 
and implement the CalculateSurface() method. 
Write a program that tests the behavior of  the CalculateSurface() method for different shapes 
(Circle, Rectangle, Triangle) stored in an array.
*/

namespace ShapesTest
{
    using System;

    class ShapesTest
    {
        static void Main()
        {
            Shape[] shapes = { new Rectangle(3, 4),
                             new Circle(4.3),
                             new Triangle(4, 5),
                             new Rectangle(2.3, 5),
                             new Circle(3),
                             new Triangle(5.7, 2.3)};

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("{0,9} with dimensions: ({1} x {2}) and surface: {3:0.000}",
                    shape.GetType().Name, shape.Width, shape.Height, shape.CalculateSurface());
            }
        }
    }
}
