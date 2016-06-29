using System.Collections.Generic;
using FormFileStore.Model;

namespace FormFileStore
{
    public interface IDataStore
    {
        void AddPerson(Person person);
        Person SearchPerson(long id);
        void DeletePerson(long id);
        HashSet<Person> GetAll();
    }
}
