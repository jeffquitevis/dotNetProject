using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormFileStore
{
    interface IMainView
    {
        long Id { get; set; }
        string FirstNameText { get; set; }
        string LastNameText { get; set; }
        long SearchText { get; set; }
        RichTextBox SearchResult { get; set; }
        long DeleteText { get; set; }
        RichTextBox GetAll { get; set; }


    }
}
