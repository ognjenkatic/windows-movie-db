using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Model.Base
{
    public class Award
    {
        public int AwardID { get; set; }

        public string AwardName { get; set; }

        public string AwardDescription { get; set; }

        public ICollection<MovieAward> AwardMovies { get; set; }

        public Award()
        {
            this.AwardMovies = new List<MovieAward>();
        }
    }
}
