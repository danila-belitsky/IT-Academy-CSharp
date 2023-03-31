using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask7.Hometask7_1
{
    internal class Library
    {
        private List<Book> _books = new List<Book>();
        public List<Reader> readers = new List<Reader>();

        public delegate void AddBook(Genre genre);

        public event AddBook AddedBook;

        public void AddBooks(params Book[] books)
        {
            foreach (var book in books)
            {
                _books.Add(book);

                Console.WriteLine($"Library: Added new book - \"{book.Title}\"(Genre - {book.Genre})");

                AddedBook(book.Genre);
            }
        }
    }
}
