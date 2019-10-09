using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_SterlingKendall
{
    public partial class DisplayQuotes : Form
    {
        public DisplayQuotes()
        {
            InitializeComponent();
        }

        private void ToAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = (AddQuote) Tag;
            viewAddQuote.Show();
            Close();
        }

        private void DisplayQuotes_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            OrderDate.Text = date.ToString("dd MMM yyyy");
        }
    }
}
