using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.II
{
    public class DbPersonServiceAdapter : IPeopleService
    {
        private DbPersonService _service;

        public DbPersonServiceAdapter(DbPersonService service)
        {
            _service = service;
        }

        public IEnumerable<Person> GetPeople()
        {
            var dbPeople = _service.Get();

            return dbPeople.Select(x => new Person { Name = $"{x.FirstName} {x.LastName}", Age = DateTime.Now.Year - x.BirthDate.Year });
        }
    }
}
