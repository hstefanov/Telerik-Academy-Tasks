namespace ShapesTest
{
    public class Triangle : Shape
    {
        //Constructor
        public Triangle()
            : this(0, 0)
        {
            
        }

        public Triangle(double triangleHeight, double triangleWidth)
            : base(triangleHeight, triangleWidth)
        {

        }

        // Methods
        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
