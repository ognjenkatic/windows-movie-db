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

        public string Title { get; set; }

        public string Tagline { get; set; }
        
        public ICollection<Quote> Quotes { get; set; }
        
        public ICollection<CastMember> Cast { get; set; }

        public ICollection<CrewMember> Crew { get; set; }

        public ICollection<TrailerLink> Trailers { get; set; }

        public ICollection<Genre> Genres { get; set; }
    }
}
