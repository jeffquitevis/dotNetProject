using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace FormFileStore
{
    public partial class Form1 : Form
    {
        private PersonStoreController psc = new PersonStoreController(new DataStoreFile());

        public Form1()
        {
            InitializeComponent();
            
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            
            psc.Add(new Person(Convert.ToInt64(tbId.Text),tbFirstName.Text, tbLastName.Text ));

        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            
            Person tempPerson = psc.Search(Convert.ToInt64(tbSearchId.Text));

            rtbSearchResult.AppendText(tempPerson.FirstName);
         
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            psc.Delete(Convert.ToInt64(tbDelete.Text));
        }
    }
}
