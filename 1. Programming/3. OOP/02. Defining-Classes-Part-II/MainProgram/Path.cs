namespace Point
{	
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 4.Create a class Path to hold a sequence of points in the 3D space. 
    /// </summary>
    
    public class Path
    {
        private List<Point3D> path;

        public Path()
        {
            this.path = new List<Point3D>();
        }

        public List<Point3D> Paths
        {
            get
            {
                return this.path;
            }
        }

        public void AddPoint(Point3D point)
        {
            Paths.Add(point);
        }

        public void PrintPathList()
        {
            foreach (var i in path)
            {
                Console.WriteLine("({0},{1},{2})", i.X, i.Y, i.Z);
            }
        }

    }
}
