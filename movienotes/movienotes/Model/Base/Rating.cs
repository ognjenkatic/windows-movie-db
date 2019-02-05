using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Model.Base
{
    public class Rating
    {
        public int RatingID { get; set; }

        public string Symbol { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Movie> Movies { get; set; }

        public Rating()
        {
            this.Movies = new List<Movie>();
        }
    }
}
