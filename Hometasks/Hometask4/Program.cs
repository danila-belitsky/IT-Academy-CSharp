namespace Hometask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point point1 = new Point(1, 1);
            //Point point2 = new Point(5, 5);

            //Console.WriteLine("Distance between points: " + Point.LengthPoints(point1, point2));
            //Console.WriteLine("Number of points: " + Point.GetNumberOfPoints());
            //Console.ReadKey();

            Factory();
        }

        public static void Factory()
        {
            Factory factory = new Factory();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tFactory\n");
                Console.WriteLine("1 - Add employee");
                Console.WriteLine("2 - Remove employee");
                Console.WriteLine("3 - Change salary");
                Console.WriteLine("4 - Change position");
                Console.WriteLine("5 - Show list of employees");
                Console.WriteLine("\n0 - Exit\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        factory.AddEmployee();
                        break;
                    case "2":
                        Console.Clear();
                        factory.RemoveEmployee();
                        break;
                    case "3":
                        Console.Clear();
                        factory.ChangeEmployeeSalary();
                        break;
                    case "4":
                        Console.Clear();
                        factory.ChangeEmployeePosition();
                        break;
                    case "5":
                        Console.Clear();
                        factory.ShowListOfEmployees();
                        Console.Write("Press any button to continue...");
                        Console.ReadKey();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Input error! Press any button to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}