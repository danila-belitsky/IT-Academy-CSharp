using Hometask6.Hometask6_1;
using Hometask6.Hometask6_2;

namespace Hometask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            List<IString> instruments = new() { new Guitar("The guitar is a fretted musical instrument that typically has six strings."),
                                                new Harp("The harp is a stringed musical instrument that has strings running at an angle to its soundboard."),
                                                new Violin("The violin is a wooden string instrument in the violin family.") };

            foreach (var instrument in instruments)
            {
                instrument.Play();
                Console.WriteLine();
            }
            
            // --

            Console.ReadKey();
            Console.Clear();

            // Task 2

            IPrintable[] bookshelf = { new Book("Crime and Punishment", "Fyodor Dostoyevsky", 492),
                                       new Magazine("Playboy", "Playboy Enterprises", 1953),
                                       new Book("The Player", "Fyodor Dostoyevsky", 224),
                                       new Magazine("Maxim", "Dennis Publishing", 1995) };

            foreach (var paper in bookshelf)
            {
                paper.Print();
            }

            Magazine.PrintMagazines(bookshelf);
            Book.PrintBooks(bookshelf);
        }
    }
}