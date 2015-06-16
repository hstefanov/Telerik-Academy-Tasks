namespace Point
{
    using System;

    public static class Distance3D
    {
        /// <summary>
        /// Write a static class with a static method to calculate the distance between two points in the 3D space.
        /// </summary>
        
        public static double CalculateDistance(Point3D first, Point3D second)
        {
            return Math.Sqrt(((first.X - second.X) * (first.X - second.X)) + ((first.Y - second.Y) * (first.Y - second.Y)) + ((first.Z - second.Z) * (first.Z - second.Z)));
        }
    }
}
