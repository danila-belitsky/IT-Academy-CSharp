using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask7.Hometask7_1
{
    internal class Book
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public Book(string title, Genre genre)
        {
            Title = title;
            Genre = genre;
        }
    }

    enum Genre
    {
        Adventure,
        Detective,
        Fantasy,
        Horror,
        Mystery,
        Thriller
    }
}
