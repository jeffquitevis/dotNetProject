using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormFileStore.View;
using FormFileStore.Model;

namespace FormFileStore.Controller
{
    class DatabaseStoreController
    {
        

        private readonly IDataStore dataStore;
        private readonly IMainView view;

        public DatabaseStoreController(IDataStore dataStore,IMainView view)
        {
            this.dataStore = dataStore;
            this.view = view;
        }

        public void Insert()
        {
            dataStore.AddPerson(new Person(view.Id,view.FirstNameText,view.LastNameText));
        }

        public Person Select()
        {
            Person tempPerson = dataStore.SearchPerson(view.SearchText);

            view.SearchResult.Clear();
            view.SearchResult.AppendText(@"PERSON ID: " + Convert.ToString(tempPerson.Id));
            view.SearchResult.AppendText("\n");
            view.SearchResult.AppendText(@"PERSON FIRSTNAME: "+ tempPerson.FirstName);
            view.SearchResult.AppendText("\n");
            view.SearchResult.AppendText(@"PERSON LASTNAME: " + tempPerson.LastName);

            return tempPerson;
        }

        public void Delete()
        {
            dataStore.DeletePerson(view.DeleteText);
        }

        public HashSet<Person> GetAllPerson()
        {
            view.SearchResult.Clear();
            HashSet<Person> tempHashSet = dataStore.GetAll();

            foreach (var person in tempHashSet) 
            {
                view.SearchResult.AppendText(@"PERSON ID: " + Convert.ToString(person.Id));
                view.SearchResult.AppendText("\n");
                view.SearchResult.AppendText(@"PERSON FIRSTNAME: " + person.FirstName);
                view.SearchResult.AppendText("\n");
                view.SearchResult.AppendText(@"PERSON LASTNAME: " + person.LastName);
                view.SearchResult.AppendText("\n");
                view.SearchResult.AppendText("\n");

            }

            return tempHashSet;
        }
    }
}
