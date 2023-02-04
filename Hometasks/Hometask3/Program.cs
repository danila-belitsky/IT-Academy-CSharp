namespace Hometask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputNumbers();
            Console.WriteLine();

            CounterLoop();
            Console.WriteLine('\n');

            ArithmeticMean();
        }

        private static void OutputNumbers()
        {
            int number = -20;

            do
            {
                Console.WriteLine(number);

                number -= 20;
            }
            while (number >= -100);
        }

        private static void CounterLoop()
        {
            for (int i = 10; i < 100; i += 5)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        private static void ArithmeticMean()
        {
            int sum = 0;
            int counter;

            int a = GetInt("Enter a: ");
            int b = GetInt("Enter b: ");

            for (counter = a; counter <= b; counter++)
            {
                sum += counter;
            }

            Console.WriteLine($"\nSum = {sum}, Arithmetic mean = {(float)sum / (counter - a)}");
        }

        private static int GetInt(string message)
        {
            int num;

            while (true)
            {
                Console.Write(message);

                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Incorrect input!");
                }
                else
                {
                    break;
                }
            }

            return num;
        }
    }
}