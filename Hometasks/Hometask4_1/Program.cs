namespace Hometask4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(5, 5);

            Console.WriteLine("Distance between points: " + LengthPoints(point1, point2));
            Console.WriteLine("Number of points: " + Point.GetNumberOfPoints());
        }

        public class Point
        {
            static int numberOfPoints = 0;

            private int x;
            public int X
            {
                get { return x; }
            }

            private int y;
            public int Y
            {
                get { return y; }
            }

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                numberOfPoints++;
            }

            static public int GetNumberOfPoints()
            {
                return numberOfPoints;
            }
        }

        public static double LengthPoints(Point firstPoint, Point secondPoint)
        {
            double distance = Math.Sqrt(Math.Pow(secondPoint.X - firstPoint.X, 2) + Math.Pow(secondPoint.Y - firstPoint.Y, 2));

            return distance;
        }

    }
}