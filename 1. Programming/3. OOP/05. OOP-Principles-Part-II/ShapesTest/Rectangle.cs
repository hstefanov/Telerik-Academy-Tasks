namespace ShapesTest
{
    public class Rectangle : Shape
    {
        // Constructor
        public Rectangle()
            : this(0, 0) { }

        public Rectangle(double rectangleHeight, double rectangleWidth)
            : base(rectangleHeight, rectangleWidth)
        {

        }

        // Methods
        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
