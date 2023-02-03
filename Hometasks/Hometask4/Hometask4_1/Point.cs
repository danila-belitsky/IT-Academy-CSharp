namespace Hometask4.Hometask4_1
{
    public class Point
    {
        private static int numberOfPoints;

        private readonly float x;
        private readonly float y;

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