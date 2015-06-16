namespace MobileDevice
{
    using System;

    public class Display
    {
        private double width;
        private double height;
        private int numberOfColors;

        //default constructor
        public Display()
            : this(0, 0, 0)
        {
        }

        public Display(double displayWidth,double displayHeight,int displayColors)
        {
            this.width = displayWidth;
            this.height = displayHeight;
            this.numberOfColors = displayColors;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width of the display cannot be negative!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height of the display cannot be negative!");
                }
                this.height = value;
            }
        }

        public int Colors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Colors should be positive number!");
                }
                this.numberOfColors = value;
            }
        }
    }
}
