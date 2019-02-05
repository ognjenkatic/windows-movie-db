using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Model.Base
{
    public class Artist
    {
        public int ArtistID { get; set; }

        public string Name { get; set; }

        public DateTime DateActiveSince { get; set; }

        public ICollection<MovieSong> MovieSongs { get; set; }

        public ICollection<ArtistMember> ArtistMemberships { get; set; }

        public Artist()
        {
            this.MovieSongs = new List<MovieSong>();
            this.ArtistMemberships = new List<ArtistMember>();
        }
    }
}
