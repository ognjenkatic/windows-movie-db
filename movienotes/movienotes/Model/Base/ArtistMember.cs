using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Model.Base
{
    public class ArtistMember
    {
        public int ArtistID { get; set; }

        public int PersonID { get; set; }

        public Artist Artist { get; set; }

        public Person Person { get; set; }
    }
}
