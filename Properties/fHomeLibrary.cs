using HomeLibrary.Properties;
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

namespace HomeLibrary
{
    public partial class fHomeLibrary : Form
    {
        public fHomeLibrary()
        {
            InitializeComponent();
        }

        private void HomeLibrary_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            library = new List<HLibrary>();
            gvBooks.AutoGenerateColumns = false;
            column.DataPropertyName = "NameBook";
            column.Width = 192;
            column.Name = "Назва книги";

            gvBooks.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "YearOfPublication";
            column.Width = 54;
            column.Name = "Рік видання";

            gvBooks.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Author";
            column.Width = 88;
            column.Name = "Автор";

            gvBooks.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "BookGenre";
            column.Width = 75;
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
                    HLibrary book = new HLibrary(split[0], split[1], split[2],
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

        private void FindBookbyAuthor(int selectedIndex)
        {
            HBook book = new HLibrary();
            List<HLibrary> libraryList = new List<HLibrary>();
            book.FindBookbyAuthor(libraryList, bindSrcBooks, "Author", gvBooks);

            if (selectedIndex < 0 || selectedIndex >= cbSearch.Items.Count)
            {
                RefreshData();
                return;
            }

            string selectedAuthor = cbSearch.Items[selectedIndex].ToString();

            if (string.IsNullOrEmpty(selectedAuthor))
            {
                RefreshData();
                return;
            }

            IEnumerable<HLibrary> searchResults = library.Where(item =>
                item.Author.Equals(selectedAuthor, StringComparison.OrdinalIgnoreCase));

            UpdateBindingSource(searchResults);
        }

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

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти данні в текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;

            StreamWriter sw;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);

                try
                {
                    foreach (HLibrary books in bindSrcBooks.List)
                    {
                        sw.Write(books.NameBook + ";" + books.Author + ";" + books.BookGenre +
                        ";" +
                        books.YearOfPublication + ";" + books.ReadSing + ";" + books.Rating + ";\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Відкрити файл";
            openFileDialog.InitialDirectory = Application.StartupPath;

            StreamReader sr = null;

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    library.Clear();
                    sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                    string s;

                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split(';');
                        HLibrary book = new HLibrary(split[0], split[1], split[2], int.Parse(split[3]),
                            split[4], int.Parse(split[5]));
                        library.Add(book);
                    }


                    bindSrcBooks.DataSource = null;
                    bindSrcBooks.DataSource = library;

                    MessageBox.Show("Файл успішно завантажено!", "Успіх", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталась помилка: {ex.Message}", "Помилка при відкритті файлу",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sr?.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                HLibrary currentBook = (HLibrary)bindSrcBooks.Current;
                if (currentBook != null)
                {
                    bindSrcBooks.RemoveCurrent();
                    library.Remove(currentBook);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
               "Закрити застосунок", "Вихід з програми?",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SwitchToMainForm();
        }
        private void SwitchToMainForm()
        {
            pnMain.Visible = false;
        }
        private void ShowMainPanel()
        {
            pnMain.Visible = true;
        }
        private void btnMainPage_Click(object sender, EventArgs e)
        {
            ShowMainPanel();
        }

        private void btnInfoPage_Click(object sender, EventArgs e)
        {
            fInfo infoForm = new fInfo();
            infoForm.ShowDialog();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortBooks(cbSort.SelectedIndex);
        }

        private void btnCancelSort_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindBookbyAuthor(cbSearch.SelectedIndex);
        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterBooks(cbFilter.SelectedIndex);
        }

        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void SortBooks(int selectedIndex)
        {
            HLibrary[] array = library.ToArray();

            switch (selectedIndex)
            {
                case 0:
                    Array.Sort(array, (a, b) => a.YearOfPublication.CompareTo(b.YearOfPublication));
                    break;
                case 1:
                    Array.Sort(array, (a, b) => b.Rating.CompareTo(a.Rating));
                    break;
            }

            bindSrcBooks.Clear();
            foreach (var item in array)
            {
                bindSrcBooks.Add(item);
            }
        }

        private void FilterBooks(int selectedIndex)
        {
            if (selectedIndex < 0 || selectedIndex >= cbFilter.Items.Count)
            {
                RefreshData();
                return;
            }

            string selectedGenre = cbFilter.Items[selectedIndex].ToString();

            if (string.IsNullOrEmpty(selectedGenre))
            {
                RefreshData();
                return;
            }

            IEnumerable<HLibrary> filteredResults = library.Where(item =>
           item.BookGenre.Equals(selectedGenre, StringComparison.OrdinalIgnoreCase));

            UpdateBindingSource(filteredResults);
        }

        private void UpdateBindingSource(IEnumerable<HLibrary> dataSource)
        {
            bindSrcBooks.DataSource = null;
            bindSrcBooks.DataSource = new BindingList<HLibrary>(dataSource.ToList());
        }
        private void RefreshData()
        {
            bindSrcBooks.Clear();
            foreach (var item in library)
            {
                bindSrcBooks.Add(item);
            }
        }

        private void btnHomeLibraryPage_Click(object sender, EventArgs e)
        {
            SwitchToMainForm();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Очистити таблицю?\nВсі данні буде втрачено", "Очищення данних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcBooks.Clear();
            }
        }
    }
}
