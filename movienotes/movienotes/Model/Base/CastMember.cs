using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Model.Base
{
    public class CastMember
    {
        public int MovieID { get; set; }

        public int PersonID { get; set; }

        public string CharacterName { get; set; }

        public bool IsCredited { get; set; }

        public string Note { get; set; }

    }
}
