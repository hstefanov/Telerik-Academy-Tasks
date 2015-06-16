namespace ShapesTest
{
    using System;

    public abstract class Shape
    {
        //Fields
        private double height;
        private double width;

        public Shape()
            : this(0, 0)
        {

        }

        public Shape(double shapeHeight, double shapeWidth)
        {
            this.Height = shapeHeight;
            this.Width = shapeWidth;
        }

        // Properties
        public double Height
        {
            get { return this.height; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be negative!");
                }
                this.height = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be negative!");
                }
                this.width = value;
            }
        }

        // Methods
        public abstract double CalculateSurface();

    }
}
