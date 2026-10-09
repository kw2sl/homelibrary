using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLibrary.Properties
{
    public partial class fInfo : Form
    {
        public fInfo()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            fHomeLibrary mainForm = Application.OpenForms.OfType<fHomeLibrary>().FirstOrDefault();  
        }

        private void btnHomeLibraryPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            fHomeLibrary mainForm = Application.OpenForms.OfType<fHomeLibrary>().FirstOrDefault();
        }
    }
}
