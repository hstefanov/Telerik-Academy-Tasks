using System;

class PointWithinCircle
{
    static void Main()
    {
        Console.Write("Enter x = ");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.Write("Enter y = ");
        decimal y = decimal.Parse(Console.ReadLine());
        decimal center_x = 0;
        decimal center_y = 5;
        decimal radius = 5;

        bool isWithinCircle = false;
        decimal dx = Math.Abs(x - center_x);
        decimal dy = Math.Abs(y - center_y);

        if (dx + dy <= radius)
        {
            isWithinCircle = true;
        }
        else if (dx > radius)
        {
            isWithinCircle = false;
        }
        else if (dy > radius)
        {
            isWithinCircle = false;
        }
        else if ((dx * dx + dy * dy) <= radius * radius)
        {
            isWithinCircle = true;
        }
        else
        {
            isWithinCircle = false;
        }
        Console.WriteLine("Is point with coordinates x : {0} and y : {1} in the circle : {2}",x,y,isWithinCircle);
    }
}

