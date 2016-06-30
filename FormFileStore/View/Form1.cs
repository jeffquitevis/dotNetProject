using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
            try
            {
                dbc.Insert();

            }
            catch (FormatException ex)
            {
                MessageBox.Show(@"Format Invalid");
                throw;
            }
            
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.Select();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(@"No Record Found" + " " + ex.StackTrace);
                throw;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(@"Wrong format" +" " + ex.StackTrace);
                throw;
            }
            
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            dbc.Delete();
          
        }

        private void bGetAll_Click(object sender, EventArgs e)
        {

            try
            {
                dbc.GetAllPerson();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(@"No Record Found");
            }
            
        }


        public TextBox Id
        {
            get {return tbId; }
            set { tbId.Text = Convert.ToInt64(value).ToString(); }
        }

        public TextBox FirstNameText
        {
            get { return tbFirstName; }
            
        }

        public TextBox LastNameText
        {
            get { return tbLastName; }
           
        }

        public TextBox SearchText
        {
            get {return  tbSearchId; }
            set { tbSearchId.Text = value.ToString();}
        }


        public RichTextBox SearchResult
        {
            get { return rtbSearchResult; }           
        }

        public TextBox DeleteText
        {
            get { return tbDelete; }
           
        }

        public RichTextBox GetAll
        {
            get; set;
        }
    }
}
