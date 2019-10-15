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
using MegaDesk_TeamEternal;
using Newtonsoft.Json;

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
            MainMenu vewMainMenu = (MainMenu)Tag;
            vewMainMenu.Show();
            Close();
        }

        private void DisplayQuote_Click(object sender, EventArgs e)
        {
            //DeskCost(firstName: FirstName.Text, lastName, string address, string city, string state, float width, float depth, int drawers, string materials, int rush);
            DeskQuote testQuote = new DeskQuote();
            testQuote.firstName = FirstName.Text;
            testQuote.lastName = LastName.Text;
            testQuote.address = address.Text;
            testQuote.city = city.Text;
            testQuote.state = state.Text;
            testQuote.orderDate = DateTime.Today;
            //testQuote.TotalCost = deskCost;

            Desk testDesk = new Desk();
            testDesk.Depth = Single.Parse(DeskDepth.Text);
            testDesk.Width = Single.Parse(DeskWidth.Text);
            testDesk.NumOfDrawers = (float)NumOfDrawers.SelectedIndex;
            testDesk.DeskType = DeskMaterials.Text;
            testDesk.RushDays = RushDelivery.Text;

            MegaDeskQuotes megaDeskQuotes = new MegaDeskQuotes
            {
                mdFirstName = FirstName.Text,
                mdLastName = LastName.Text,
                mdAddress = address.Text,
                mdCity = city.Text,
                mdState = state.Text,
                mdOrderDate = DateTime.Today,
                mdWidth = Single.Parse(DeskWidth.Text),
                mdDepth = Single.Parse(DeskDepth.Text),
                mdNumOfDrawers = (float)NumOfDrawers.SelectedIndex,
                mdDeskType = DeskMaterials.Text,
                mdRushDays = RushDelivery.Text,
                //mdTotalCost = DeskQuote.DeskCost();
            };

            string result = JsonConvert.SerializeObject(megaDeskQuotes);
            //textBox1.Text = result;
            string cFile = @"quotes.json";
            if (!File.Exists(cFile))
            {
                using (StreamWriter sw = File.CreateText(cFile))
                {
                }
            }
            using (StreamWriter sw = File.AppendText(cFile))
            {
                sw.WriteLine(result);
            }

            DisplayQuotes viewDisplayQuotes = new DisplayQuotes();
            viewDisplayQuotes.Tag = this;
            viewDisplayQuotes.Show(this);
            Hide();

             

            try
            {
                DeskQuote.DeskCost(ref testDesk, ref testQuote, ref viewDisplayQuotes);
                //DeskQuote.DeskCost(FirstName.Text, LastName.Text, address.Text, city.Text, state.Text,
                //    float.Parse(DeskWidth.Text), float.Parse(DeskDepth.Text), float.Parse(NumOfDrawers.Text),
                //    DeskMaterials.Text, float.Parse(RushDelivery.Text), ref viewDisplayQuotes);

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
                if ((int)MegaConst.MinWidth < oWidth && oWidth < (int)MegaConst.MaxWidth)
                {
                    DeskWidth.BackColor = Color.LawnGreen;
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
            NumOfDrawers.DataSource = Enum.GetValues(typeof(NumOfDrawers));
            DeskMaterials.DataSource = Enum.GetValues(typeof(DeskType));
            RushDelivery.DataSource = Enum.GetValues(typeof(RushDays));
        }

        private void DeskDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            float oDepth;
            //string.IsNullOrEmpty(DeskDepth.Text);  && char.IsDigit(DeskDepth.Text, 1)

            if (float.TryParse(DeskDepth.Text, out oDepth) && (char.IsDigit(DeskDepth.Text, 0)))
            {
                if ((int)MegaConst.MinDepth < oDepth && oDepth < (int)MegaConst.MaxDepth)
                {
                    DeskDepth.BackColor = Color.LawnGreen;
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
}
