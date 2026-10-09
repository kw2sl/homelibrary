using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Library.Properties
{
    public partial class HomeLibrary : Form
    {
        public HomeLibrary()
        {
            InitializeComponent();
        }

        private void HomeLibrary_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            library = new List<HLibrary>();
            gvBooks.AutoGenerateColumns = false;
            column.DataPropertyName = "NameBook";
            column.Name = "Назва";

            gvBooks.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "YearOfPublication";
            column.Name = "Рік видання";

            gvBooks.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Author";
            column.Name = "Автор";

            gvBooks.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "BookGenre";
            column.Name = "Жанр";

            gvBooks.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ReadSing";
            column.Name = "Ознака прочитання";

            gvBooks.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Rating";
            column.Name = "Рейтинг";

            gvBooks.Columns.Add(column);
            bindSrcBooks.Clear();
            gvBooks.DataSource = bindSrcBooks;

            FileStream fs = new FileStream("Books.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            string text;
            try
            {
                while ((text = sr.ReadLine()) != null)
                {
                    string[] split = text.Split(';');
                    HLibrary book = new HLibrary (split[0], split[1], split[2],
                    int.Parse(split[3]), (split[4]), int.Parse(split[5]));
                    bindSrcBooks.Add(book);
                    library.Add(book);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                sr.Close();
            }
            EventArgs args = new EventArgs();
            OnResize(args);
        }
        static List<HLibrary> library;

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            HLibrary book = new HLibrary();
            fNewBook form = new fNewBook(ref book);
            if (form.ShowDialog() == DialogResult.OK)
            {
                bindSrcBooks.Add(book);
                library.Add(book);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            HLibrary book = (HLibrary)bindSrcBooks.List[bindSrcBooks.Position];
            fNewBook form = new fNewBook(ref book);
            try
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    bindSrcBooks.List[bindSrcBooks.Position] = book;
                }
            }
            catch
            {
                MessageBox.Show("Редагування обраного рядка");
            }
        }
    }
}
