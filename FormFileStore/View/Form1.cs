using System;
using System.Windows.Forms;
using System.Collections.Generic;
using FormFileStore.Controller;
using FormFileStore.Model;

namespace FormFileStore.View
{
    public partial class Form1 : System.Windows.Forms.Form, IMainView
    {
        private DatabaseStoreController dbc;

        public Form1()
        {
            dbc = new DatabaseStoreController(new DataStoreDatabase(),this);
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {          
            dbc.Insert();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            dbc.Select();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            dbc.Delete();
        }

        private void bGetAll_Click(object sender, EventArgs e)
        {

            dbc.GetAllPerson();
        }


        public long Id
        {
            get {return Convert.ToInt64(tbId.Text); }
            set { tbId.Text = Convert.ToInt64(value).ToString(); }
        }

        public string FirstNameText
        {
            get { return tbFirstName.Text; }
            set { tbFirstName.Text = value; }
        }

        public string LastNameText
        {
            get {return  tbLastName.Text;}
            set { tbLastName.Text = value; }
        }

        public long SearchText
        {
            get {return  Convert.ToInt64(tbSearchId.Text); }
            set { tbSearchId.Text = value.ToString();}
        }


        public RichTextBox SearchResult
        {
            get { return rtbSearchResult; }

            set { rtbSearchResult.Text = value.ToString(); }
        }

        public long DeleteText
        {
            get { return Convert.ToInt64(tbDelete.Text); }
            set { tbDelete.Text = value.ToString(); }
        }

        public RichTextBox GetAll
        {
            get; set;
        }
    }
}
