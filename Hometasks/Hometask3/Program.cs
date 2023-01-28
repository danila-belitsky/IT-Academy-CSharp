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

            ArithmeticMean(1, 3);
        }

        private static void OutputNumbers()
        {
            int number = -20;

            do
            {
                Console.WriteLine(number);

                number -= 20;
            } while (number >= -100);
        }

        private static void CounterLoop()
        {
            for (int i = 10; i < 100; i += 5)
            {
                Console.Write(i + " ");
            }
        }

        private static void ArithmeticMean(int a, int b)
        {
            int sum = 0, counter;

            for (counter = a; counter <= b; counter++)
            {
                sum += counter;
            }

            Console.WriteLine($"Sum = {sum}, Arithmetic mean = {sum/(counter - a)}");
        }
    }
}