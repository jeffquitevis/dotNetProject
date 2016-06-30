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
        TextBox Id { get; }
        TextBox FirstNameText { get;  }
        TextBox LastNameText { get; }
        TextBox SearchText { get; }
        RichTextBox SearchResult { get;  }
        TextBox DeleteText { get; }
        RichTextBox GetAll { get; }


    }
}
