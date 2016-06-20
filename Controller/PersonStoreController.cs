namespace Controller
{
    public class PersonStoreController
    {
        private IDataStore dataStore;

        public PersonStoreController(IDataStore dataStore)
        {
            this.dataStore = dataStore;
        }

        public void Add(Person person)
        {
            dataStore.AddPerson(person);
        }

        public Person Search(long id)
        {
            return dataStore.SearchPerson(id);
        }

        public void Delete(long id)
        {
            dataStore.DeletePerson(id);
        }

    }
}
