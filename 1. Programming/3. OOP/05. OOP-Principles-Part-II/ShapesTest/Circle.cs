namespace ShapesTest
{
    using System;

    public class Circle : Shape
    {
        // Fields
        private readonly double radius;

        // Constructors
        public Circle()
            : this(0) { }

        public Circle(double radius)
            : base(2 * radius, 2 * radius)
        {
            this.radius = radius;
        }

        // Methods
        public override double CalculateSurface()
        {
            return Math.PI * radius * radius;
        }
    }
}
