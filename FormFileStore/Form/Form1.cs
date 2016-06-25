using System;
using FormFileStore.Controller;
using FormFileStore.Model;

namespace FormFileStore.Form
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        //private PersonStoreController psc = new PersonStoreController(new DataStoreFile());
        private DatabaseStoreController dsc = new DatabaseStoreController(new DataStoreDatabase());

        public Form1()
        {
            InitializeComponent();
            
        }

        private void bAdd_Click(object sender, EventArgs e)
        {

            dsc.Insert(new Person(Convert.ToInt64(tbId.Text), tbFirstName.Text, tbFirstName.Text));

            //psc.Add(new Person(Convert.ToInt64(tbId.Text),tbFirstName.Text, tbLastName.Text ));
            //tbId.Clear();
            //tbFirstName.Clear();
            //tbLastName.Clear();

        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            
            Person tempPerson = dsc.Select(Convert.ToInt64(tbSearchId.Text));

            rtbSearchResult.Clear();
            rtbSearchResult.AppendText("ID: " + tempPerson.Id);
            rtbSearchResult.AppendText("\n");
            rtbSearchResult.AppendText("FIRSTNAME: " + tempPerson.FirstName);
            rtbSearchResult.AppendText("\n");
            rtbSearchResult.AppendText("LASTNAME: " + tempPerson.LastName);
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            //psc.Delete(Convert.ToInt64(tbDelete.Text));
            dsc.Delete(Convert.ToInt64(tbDelete.Text));
        }
    }
}
