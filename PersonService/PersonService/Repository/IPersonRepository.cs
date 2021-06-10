using System.Collections.Generic;
using PersonService.Model;

namespace PersonService.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);

        List<Person> FindByName(string firstName, string lastName);
    }
}