using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Home_Library.Properties
{
    public partial class fNewBook : Form
    {
        HLibrary library = new HLibrary();

        private void fNewBook_Load(object sender, EventArgs e)
        {
            if (library != null)
            {
                tbNameBook.Text = library.NameBook;
                tbAuthor.Text = library.Author;
                tbBookGenre.Text = library.BookGenre;
                tbYearOfPublication.Text = library.YearOfPublication.ToString();
                tbReadSing.Text = library.ReadSing;
                tbRating.Text = library.Rating.ToString();
            }
        }
        public fNewBook(ref HLibrary lib)
        {
            InitializeComponent();
            library = lib;
            tbNameBook.Text = lib.NameBook;
            tbAuthor.Text = lib.Author;
            tbBookGenre.Text = lib.BookGenre;
            tbYearOfPublication.Text = lib.YearOfPublication.ToString();
            tbReadSing.Text = lib.ReadSing;
            tbRating.Text = lib.Rating.ToString();
        }
        public fNewBook()
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            library.NameBook = tbNameBook.Text;
            library.Author = tbAuthor.Text;
            library.BookGenre = tbBookGenre.Text;
            library.YearOfPublication = int.Parse(tbYearOfPublication.Text);
            library.ReadSing = tbReadSing.Text;
            library.Rating = int.Parse(tbRating.Text);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
    
}
