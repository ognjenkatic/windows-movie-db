using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Model.Base
{
    public class MovieAward
    {
        public int MovieID { get; set; }

        public int AwardID { get; set; }

        public Movie Movie { get; set; }

        public Award Award { get; set; }
    }
}
