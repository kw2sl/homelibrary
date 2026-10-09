using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLibrary.Properties
{
    public abstract class HBook
    {
        public string NameBook { get; set; }
        public string Author { get; set; }
        public string BookGenre { get; set; }
        public abstract void FindBookbyAuthor(List<HLibrary> library, BindingSource bs1,
        string author, DataGridView dg1);
        protected HBook(string name, string author, string bookGenre)
        {
            NameBook = name;
            Author = author;
            BookGenre = bookGenre;
        }
        public HBook() 
        { }
    }
}
