using System;
using System.Windows.Forms;

namespace MegaDesk2_TeamEternal
{
    public partial class DisplayQuotes : Form
    {
        public DisplayQuotes()
        {
            InitializeComponent();

            }
        private void ToAddQuote_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Show();
            this.Close();
        }

        private void DisplayQuotes_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            OrderDate.Text = date.ToString("dd MMM yyyy");
        }

    }
}
