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

            GetFileName(@"c:\WebServers\home\testsite\www\myfile.txt");
            Console.WriteLine('\n');

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

        private static void GetFileName(string path)
        {
            Regex regex = new Regex(@"\w+");

            MatchCollection matchCollection = regex.Matches(path);

            Console.WriteLine(matchCollection[^2]);
        }

        private static void GetAmountOfWords(string text)
        {
            Regex regex = new Regex(@"\w+");

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine(matchCollection.Count);
        }
    }
}