using Hometask7.Hometask7_1;

namespace Hometask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            
            library.AddedBook += Notify;

            Reader reader0 = new Reader(0);
            Reader reader1 = new Reader(1);
            Reader reader2 = new Reader(2);
            Reader reader3 = new Reader(3);

            library.readers.Add(reader0);
            library.readers.Add(reader1);
            library.readers.Add(reader2);
            library.readers.Add(reader3);

            reader0.Subscribe(Genre.Adventure);
            reader0.Subscribe(Genre.Mystery);
            reader1.Subscribe(Genre.Detective);
            reader2.Subscribe(Genre.Fantasy);
            reader3.Subscribe(Genre.Adventure);
            reader3.Subscribe(Genre.Mystery);
            reader3.Subscribe(Genre.Detective);
            reader3.Subscribe(Genre.Fantasy);

            Book book0 = new Book("adv_book", Genre.Adventure);
            Book book1 = new Book("det_book", Genre.Detective);
            Book book2 = new Book("fan_book", Genre.Fantasy);
            Book book3 = new Book("mys_book", Genre.Mystery);

            library.AddBooks(book0);
            library.AddBooks(book0);
            library.AddBooks(book1);
            library.AddBooks(book2);
            library.AddBooks(book3);
            library.AddBooks(book0);


            void Notify(Genre genre)
            {
                foreach (var reader in library.readers)
                {
                    if (reader.subs[genre])
                    {
                        Console.WriteLine($"Reader(UserID: {reader.Id}) was notified.");
                    }
                }
            }
        }
    }
}