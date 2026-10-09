using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Library.Properties
{
    public class HLibrary : HBook
    {
        public int YearOfPublication { get; set; }
        public string ReadSing { get; set; }
        public int Rating { get; set; }
        public override void FindBookbyAuthor(List<HLibrary> books, BindingSource bs1,
        string surname, DataGridView dg1)
        {
            bs1.Clear();
            foreach (HLibrary item in books)
            {
                if (item.Author.Contains(surname))
                {
                    bs1.Add(item);
                }
            }
            dg1.DataSource = bs1;
        }
        public void SortBook(ref HLibrary[] arr, int id)
        {
            HLibrary[] array = arr as HLibrary[];
            HLibrary temp;
            string[] prod = new string[array.Length];
            switch (id)
            {
                case 0:
                    break;
                case 1:
                    for (int i = 0; i < array.Length; i++)
                    {
                        prod[i] = array[i].NameBook;
                    }
                    Array.Sort(prod, array);
                    break;
                case 2:
                    for (int i = 0; i < array.Length; i++)
                    {
                        prod[i] = array[i].Author;
                    }
                    Array.Sort(prod, array);
                    break;
                case 3:
                    for (int i = 0; i < array.Length; i++)
                    {
                        prod[i] = array[i].BookGenre;
                    }
                    Array.Sort(prod, array);
                    break;
                case 4:
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (array[i].YearOfPublication > array[j].YearOfPublication)
                            {
                                temp = array[i];
                                array[i] = array[j];
                                array[j] = temp;
                            }
                        }
                    }
                    break;
                case 5:
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (int.TryParse(array[i].ReadSing, out int yearI) && int.TryParse(array[j].ReadSing, 
                                out int yearJ))
                            {
                                if (yearI > yearJ)
                                {
                                    temp = array[i];
                                    array[i] = array[j];
                                    array[j] = temp;
                                }
                            }
                            else
                            {
                            }
                        }
                    }

                    break;
                case 6:
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (array[i].YearOfPublication > array[j].Rating)
                            {
                                temp = array[i];
                                array[i] = array[j];
                                array[j] = temp;
                            }
                        }
                    }
                    break;
            }
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

