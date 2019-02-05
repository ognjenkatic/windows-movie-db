using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Model.Base
{
    public class CrewPosition
    {
        public int CrewPositionID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<CrewMember> CrewMemberships { get; set; }

        public CrewPosition()
        {
            this.CrewMemberships = new List<CrewMember>();
        }
    }
}
