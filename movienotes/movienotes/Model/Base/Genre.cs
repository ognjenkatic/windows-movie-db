using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Model.Base
{
    public class Genre
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int GenreID { get; set; }

        public ICollection<MovieGenre> MovieGenres { get; set; }

        public Genre()
        {
            this.MovieGenres = new List<MovieGenre>();
        }
    }
}
