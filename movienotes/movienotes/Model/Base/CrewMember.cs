using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Model.Base
{
    public class CrewMember
    {
        public int MovieID { get; set; }

        public int PersonID { get; set; }

        public int CrewPositionID { get; set; }

        public Movie Movie { get; set; }

        public Person Person { get; set; }

    }
}
