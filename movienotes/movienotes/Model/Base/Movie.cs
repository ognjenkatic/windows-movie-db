using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Model.Base
{
    public class Movie
    {
        public int MovieID { get; set; }

        public int RatingID { get; set; }

        public string Title { get; set; }

        public string Tagline { get; set; }

        public int YearOfRelease { get; set; }

        public int DurationMinutes { get; set; }

        public string Sinopsis { get; set; }

        public ICollection<MovieSong> MovieSongs { get; set; }
        
        public ICollection<Quote> Quotes { get; set; }
        
        public ICollection<CastMember> CastMembers { get; set; }

        public ICollection<CrewMember> CrewMembers { get; set; }

        public ICollection<TrailerLink> TrailerLinks { get; set; }

        public ICollection<MovieGenre> MovieGenres { get; set; }

        public ICollection<MovieAward> MovieAwards { get; set; }
    }
}
