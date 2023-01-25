namespace Hometask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
        }
        public static void Task1()
        {
            int legA = GetIntNumber("Введите значение катета a: ", false);
            int legB = GetIntNumber("Введите значение катета b: ", false);

            Console.WriteLine($"Гипотенуза равна: {Math.Sqrt(legA * legA + legB * legB)}");
        }

        public static void Task2()
        {
            int a = GetIntNumber("Введите первный множитель: ", true);
            int b = GetIntNumber("Введите второй множитель: ", true);

            Console.WriteLine($"Результат умножения: {a * b}");
        }

        public static void Task3()
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

        public static void Task4()
        {
            decimal deposit = Convert.ToDecimal(GetIntNumber("Введите размер вклада: ", false));
            int numOfMonths = GetIntNumber("Введите кол-во месяцев: ", false);

            for (int i = 0; i < numOfMonths; i++)
            {
                deposit += deposit / 100 * 7;
            }

            Console.WriteLine($"Итоговая сумма: {deposit}");
        }

        public static int GetIntNumber(string msg, bool underTen)
        {
            int number;
            do
            {
                Console.Write(msg);
                
                number = Convert.ToInt32(Console.ReadLine());
                if (number <= 0)
                {
                    Console.WriteLine("Число должно быть больше 0!");
                }
                else if (underTen && number > 10)
                {
                    Console.WriteLine("Число должно быть меньше 10!");
                }
                else
                {
                    break;
                }
            } while (number <= 0 || number > 10);

            return number;
        }
    }

}