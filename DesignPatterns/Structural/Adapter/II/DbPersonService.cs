using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.II
{
    public class DbPersonService
    {
        private readonly IEnumerable<DbPerson> _people = new List<DbPerson>() { new DbPerson { FirstName = "Ewa", LastName = "Ewowska", BirthDate = new DateTime(1974, 12, 2) },
        new DbPerson { FirstName = "Piotr", LastName = "Piotrowski", BirthDate = new DateTime(2001, 4, 18) },
        new DbPerson { FirstName = "Michał", LastName = "Michalski", BirthDate = new DateTime(1988, 1, 22) }};

        public IEnumerable<DbPerson> Get()
        {
            return _people.Select(x => x.Clone()).Cast<DbPerson>();
        }
    }
}
