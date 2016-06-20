using Model;

namespace FormFileStore
{
    public interface IDataStore
    {

        void AddPerson(Person person);
        Person SearchPerson(long id);
        void DeletePerson(long id);
    }
}
