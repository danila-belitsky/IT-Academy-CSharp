namespace Hometask4.Hometask4_2
{
    public static class Methods
    {
        public static int GetInt(string message)
        {
            int num;
            string? input;

            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();

                if (!int.TryParse(input, out num))
                {
                    Console.WriteLine("Input error!\n");
                }
                else if (num < 0)
                {
                    Console.WriteLine("Cannot be less than zero!\n");
                }
                else
                {
                    break;
                }
            }

            return num;
        }

        public static string GetString(string message)
        {
            string? input;

            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input error!\n");
                }
                else
                {
                    break;
                }
            }

            return input;
        }
    }
}
