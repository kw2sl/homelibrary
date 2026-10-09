using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLibrary.Properties
{
    public class HLibrary : HBook
    {
        public int YearOfPublication { get; set; }
        public string ReadSing { get; set; }
        public double Rating { get; set; }
        public override void FindBookbyAuthor(List<HLibrary> books,
            BindingSource bs1, string author, DataGridView dg1)
        {
            bs1.Clear();
            foreach (HLibrary item in books)
            {
                if (item.Author.Contains(author))
                {
                    bs1.Add(item);
                }
            }
            dg1.DataSource = bs1;
        }

        public HLibrary(string nameBook, string author, string bookGenre, int yearOfPublication, string readSing,
        int rating) : base(nameBook, author, bookGenre)
        {
            NameBook = nameBook;
            Author = author;
            BookGenre = bookGenre;
            YearOfPublication = yearOfPublication;
            ReadSing = readSing;
            Rating = rating;
        }
        public HLibrary() { }
    }
}
