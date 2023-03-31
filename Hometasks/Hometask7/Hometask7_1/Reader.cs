using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask7.Hometask7_1
{
    internal class Reader
    {
        public int Id { get; set; }

        public Dictionary<Genre, bool> subs = new Dictionary<Genre, bool>() { { Genre.Adventure, false },
                                                                       { Genre.Detective, false },
                                                                       { Genre.Fantasy, false },
                                                                       { Genre.Horror, false },
                                                                       { Genre.Mystery, false },
                                                                       { Genre.Thriller, false }, };

        public Reader(int id)
        {
            Id = id;
        }

        public void Subscribe(Genre genre)
        {
            subs[genre] = true;
        }
    }
}
