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
            dataStore.AddPerson(new Person(Convert.ToInt64(view.Id.Text),view.FirstNameText.Text,view.LastNameText.Text));

            view.Id.Clear();
            view.FirstNameText.Clear();
            view.LastNameText.Clear();            


        }

        public Person Select()
        {
            Person tempPerson = dataStore.SearchPerson(Convert.ToInt64(view.SearchText.Text));

            view.SearchResult.Clear();
            view.SearchText.Clear();
            view.SearchResult.AppendText(@"PERSON ID: " + Convert.ToString(tempPerson.Id));
            view.SearchResult.AppendText("\n");
            view.SearchResult.AppendText(@"PERSON FIRSTNAME: "+ tempPerson.FirstName);
            view.SearchResult.AppendText("\n");
            view.SearchResult.AppendText(@"PERSON LASTNAME: " + tempPerson.LastName);
            

            return tempPerson;
        }

        public void Delete()
        {
            dataStore.DeletePerson(Convert.ToInt64(view.DeleteText.Text));
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
