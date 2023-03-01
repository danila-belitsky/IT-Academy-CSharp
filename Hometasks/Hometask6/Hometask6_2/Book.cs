namespace Hometask6.Hometask6_2
{
    internal class Book : IPrintable
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int NumOfPages { get; set; }

        public void Print()
        {
            Console.WriteLine($"Book name : {Name}\n" +
                              $"Author: {Author}\n" +
                              $"Number of pages: {NumOfPages}\n");
        }

        public static void PrintBooks(IPrintable[] printable)
        {
            Console.WriteLine("\nBooks:");

            foreach (var item in printable)
            {
                if (item is Book book)
                {
                    Console.WriteLine(book.Name);
                }
            }
        }

        public Book(string name, string author, int numOfPages)
        {
            Name = name;
            Author = author;
            NumOfPages = numOfPages;
        }
    }
}
