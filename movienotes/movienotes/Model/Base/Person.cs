using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Model.Base
{
    public class Person
    {
        public int PersonID { get; set; }

        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string CountryOfBirth { get; set; }

        public string CityOfBirth { get; set; }

        public string Nationality { get; set; }

        public string Biography { get; set; }

        public ICollection<CrewMember> CrewMemberships { get; set; }

        public ICollection<CastMember> CastMemberships { get; set; }

        public ICollection<ArtistMember> ArtistMemberships { get; set; }
    }
}
