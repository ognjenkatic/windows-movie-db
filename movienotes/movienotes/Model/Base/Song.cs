using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Model.Base
{
    public class Song
    {
        public int SongID { get; set; }

        public ICollection<Performer> Performers;

        public string Title { get; set; }
    }
}
