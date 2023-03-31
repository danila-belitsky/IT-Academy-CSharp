namespace Hometask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindHypotenuse();

            Console.ReadKey();
            Console.Clear();

            Multiplication();

            Console.ReadKey();
            Console.Clear();

            MultiplicationTable();

            Console.ReadKey();
            Console.Clear();

            Deposit();
        }
        private static void FindHypotenuse()
        {
            int legA = GetIntNumber("Введите значение катета a: ", 0, int.MaxValue);
            int legB = GetIntNumber("Введите значение катета b: ", 0, int.MaxValue);

            Console.WriteLine($"Гипотенуза равна: {Math.Sqrt(legA * legA + legB * legB)}");
        }

        private static void Multiplication()
        {
            int a = GetIntNumber("Введите первный множитель: ", -1, 11);
            int b = GetIntNumber("Введите второй множитель: ", -1, 11);

            Console.WriteLine($"Результат умножения: {a * b}");
        }

        private static void MultiplicationTable()
        {
            int posTop = Console.CursorTop;
            int posLeft = Console.CursorLeft;

            Console.SetWindowSize(135, Console.WindowHeight);

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.SetCursorPosition(posLeft, posTop);
                    Console.WriteLine($"{i} ∙ {j} = {i * j}");
                    posTop += 1;
                }
                posLeft += 13;
                posTop = 0;
            }
        }

        private static void Deposit()
        {
            decimal deposit = Convert.ToDecimal(GetIntNumber("Введите размер вклада: ", 0, int.MaxValue));
            int numOfMonths = GetIntNumber("Введите кол-во месяцев: ", 0, int.MaxValue);

            for (int i = 0; i < numOfMonths; i++)
            {
                deposit += deposit / 100 * 7;
            }

            Console.WriteLine($"Итоговая сумма: {deposit}");
        }
        
        private static int GetIntNumber(string message, int min, int max)
        {
            int number;

            while (true)
            {
                Console.Write(message);

                number = Convert.ToInt32(Console.ReadLine());

                if (number <= min)
                {
                    Console.WriteLine($"Число должно быть больше {min}!");
                }
                else if (number >= max)
                {
                    Console.WriteLine($"Число должно быть меньше {max}!");
                }
                else
                {
                    break;
                }
            }

            return number;
        }

    }
}