namespace Hometask6.Hometask6_2
{
    internal class Magazine : IPrintable
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int PublicationYear { get; set; }

        public void Print()
        {
            Console.WriteLine($"Magazine name : {Name}\n" +
                              $"Publisher: {Publisher}\n" +
                              $"Publication year: {PublicationYear}\n");
        }

        public static void PrintMagazines(IPrintable[] printable)
        {
            Console.WriteLine("\nMagazines:");

            foreach (var item in printable)
            {
                if (item is Magazine mag)
                {
                    Console.WriteLine(mag.Name);
                }
            }
        }

        public Magazine(string name, string publisher, int year)
        {
            Name = name;
            Publisher = publisher;
            PublicationYear = year;
        }
    }
}
