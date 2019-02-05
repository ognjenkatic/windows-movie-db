using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Model.Base
{
    public class MovieSong
    {
        public int ArtistID { get; set; }

        public int MovieID { get; set; }

        public string Title { get; set; }

        public Movie Movie { get; set; }

        public Artist Artist { get; set; }
    }
}
