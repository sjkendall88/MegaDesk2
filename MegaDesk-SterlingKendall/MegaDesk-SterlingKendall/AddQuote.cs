using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MegaDesk2_TeamEternal
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu vewMainMenu = (MainMenu) Tag;
            vewMainMenu.Show();
            Close();
        }

        private void DisplayQuote_Click(object sender, EventArgs e)
        {
            DeskQuote testQuote = new DeskQuote();
            testQuote.firstName = FirstName.Text;
            testQuote.lastName = LastName.Text;
            testQuote.address = address.Text;
            testQuote.city = city.Text;
            testQuote.state = state.Text;
            testQuote.orderDate = DateTime.Today;

            Desk testDesk = new Desk();
            //if depth or width empty, set as minimum values
            if (DeskWidth.Text == "")
            {
                DeskWidth.Text = "24";
            }

            if (DeskDepth.Text == "")
            {
                DeskDepth.Text = "12";
            }
            testDesk.Depth = Single.Parse(DeskDepth.Text);
            testDesk.Width = Single.Parse(DeskWidth.Text);
            testDesk.NumOfDrawers = (float) NumOfDrawers.SelectedIndex;
            testDesk.DeskType = DeskMaterials.Text;
            testDesk.RushDays = RushDelivery.Text;
            
            DisplayQuotes viewDisplayQuotes = new DisplayQuotes();
            viewDisplayQuotes.Tag = this;
            viewDisplayQuotes.Show(this);
            Hide();



            try
            {
                DeskQuote.DeskCost(ref testDesk, ref testQuote, ref viewDisplayQuotes);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace);
            }
        }

        private void DeskWidth_Validating(object sender, CancelEventArgs e)
        {
            float oWidth;

            if (float.TryParse(DeskWidth.Text, out oWidth) && !(string.IsNullOrEmpty(DeskWidth.Text)))
            {
                if ((int) MegaConst.MinWidth < oWidth && oWidth < (int) MegaConst.MaxWidth)
                {
                    DeskWidth.BackColor = Color.White;
                }
                else
                {
                    DeskWidth.BackColor = Color.Crimson;
                }
            }
            else
            {
                DeskWidth.BackColor = Color.Crimson;
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            // Bind Values to combobox
            /* NumOfDrawers.DataSource = Enum.GetValues(typeof(NumOfDrawers)).Cast<NumOfDrawers>()
             * The above declaration returns the value of the enum selection but doesn't print it to the
             * combobox. Will test this on the SearchQuotes window.
             */
            NumOfDrawers.DataSource = Enum.GetValues(typeof(NumOfDrawers));
            DeskMaterials.DataSource = Enum.GetValues(typeof(DeskType));
            RushDelivery.DataSource = Enum.GetValues(typeof(RushDays));
        }


        private void DeskDepth_Leave(object sender, EventArgs e)
        {
            float oDepth;
            //string.IsNullOrEmpty(DeskDepth.Text);  && char.IsDigit(DeskDepth.Text, 1)

            if (float.TryParse(DeskDepth.Text, out oDepth) && (char.IsDigit(DeskDepth.Text, 0)))
            {
                if ((int) MegaConst.MinDepth < oDepth && oDepth < (int) MegaConst.MaxDepth)
                {
                    DeskDepth.BackColor = Color.White;
                }
                else
                {
                    DeskDepth.BackColor = Color.Crimson;
                }
            }
            else
            {
                DeskDepth.BackColor = Color.Crimson;
            }
        }


        }
    };