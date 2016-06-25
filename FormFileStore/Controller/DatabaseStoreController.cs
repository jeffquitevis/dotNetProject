using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormFileStore.Model;

namespace FormFileStore.Controller
{
    class DatabaseStoreController
    {

        private IDataStore dataStore;

        public DatabaseStoreController(IDataStore dataStore)
        {
            this.dataStore = dataStore;
        }

        public void Insert(Person person)
        {
            dataStore.AddPerson(person);
        }

        public Person Select(long id)
        {
            return dataStore.SearchPerson(id);
        }
    }
}
