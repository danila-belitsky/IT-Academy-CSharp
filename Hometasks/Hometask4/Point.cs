using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask4
{
    public class Point
    {
        private static int numberOfPoints = 0;

        private float x;
        private float y;

        public float X => x;
        public float Y => y;

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
            numberOfPoints++;
        }
        public static int GetNumberOfPoints()
        {
            return numberOfPoints;
        }

        public static double LengthPoints(Point firstPoint, Point secondPoint)
        {
            return Math.Sqrt(Math.Pow(secondPoint.X - firstPoint.X, 2) + Math.Pow(secondPoint.Y - firstPoint.Y, 2));
        }
    }
}
