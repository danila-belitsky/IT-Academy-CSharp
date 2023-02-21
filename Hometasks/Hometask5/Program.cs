using System.Text.RegularExpressions;

namespace Hometask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arr();
            Console.WriteLine('\n');

            GetMaxNumber();
            Console.WriteLine('\n');

            GetFileName("c:\\WebServers\\home\\testsite\\www\\myfile.txt");
            Console.WriteLine('\n');

            GetFileName0("c:\\WebServers\\home\\testsite\\www\\myfile.txt");
            Console.WriteLine('\n');

            GetFileName1("c:\\WebServers\\home\\testsite\\www\\myfile.txt");

            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor " +
                          "incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis " +
                          "nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.";

            GetAmountOfWords(text);
        }

        private static void Arr()
        {
            int[] arr = new int[6];

            for (int i = 0; i < arr.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out arr[i]);
            }

            Array.Sort(arr);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Array.Reverse(arr);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            for (int i = 3; i > 0; i--)
            {
                Console.Write(arr[^i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 5 && arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

        private static void GetMaxNumber()
        {
            int[,] array = new int[3, 3] { { 1, 4, 3 }, { 7, 5, 6 }, { 7, 8, 9 } };
            int max = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }

                Console.Write(max + " ");
                max = 0;
            }
        }

        // Работа со строками
        // Это первое что мне пришло в голову
        private static void GetFileName(string path)
        {
            string[] words = path.Split('\\');
            string[] fileName = words[^1].Split('.');
            Console.Write(fileName[0]);
        }

        // А это второе
        private static void GetFileName0(string path)
        {
            List<char> letters = new List<char>();

            for (int i = path.Length - 1; i >= 0; i--)
            {
                if (path[i] == '.')
                {
                    i--;
                    while (path[i] != '\\')
                    {
                        letters.Add(path[i]);
                        i--;
                    }
                    break;
                }
            }

            for (int i = letters.Count - 1; i >= 0; i--)
            {
                Console.Write(letters[i]);
            }

            // либо ещё можно перевернуть и вывести

            //letters.Reverse();
            //foreach (char letter in letters)
            //{
            //    Console.Write(letter);
            //}
        }

        // И ещё вот такой вариант, крайне не практичный, но по сути задачу по выводу имени тоже выполняет :)
        private static void GetFileName1(string path)
        {
            for (int i = path.Length - 1; i >= 0; i--)
            {
                if (path[i] == '.')
                {
                    while (path[i-1] != '\\')
                    {
                        i--;
                        // установить каретку где-то ближе к центру первой строки консоли, чтобы был запас длины на случай длинного имени файла
                        Console.SetCursorPosition(i + 20, 0);
                        Console.Write(path[i]);
                    }
                    Console.SetCursorPosition(0, 17);
                    break;
                }
            }
        }

        private static void GetAmountOfWords(string text)
        {
            Regex regex = new Regex(@"\w+");

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine(matchCollection.Count);
        }
    }
}