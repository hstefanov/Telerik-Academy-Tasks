namespace Point
{
    using System;

    /// <summary>
    /// 1.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
    /// Implement the ToString() to enable printing a 3D point.
    /// </summary>
    public struct Point3D
    {
        private static readonly Point3D startCoord = new Point3D(0, 0, 0);

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x, int y, int z)
            : this()
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return String.Format("({0},{1},{2})", X, Y, Z);
        }

        /// <summary>
        /// 2.Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
        /// Add a static property to return the point O.
        /// </summary>
        /// 
        public static Point3D ZeroCoord()
        {
            return startCoord;
        }
    }
}
