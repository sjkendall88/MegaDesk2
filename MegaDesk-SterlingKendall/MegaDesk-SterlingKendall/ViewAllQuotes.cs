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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

            string cFile = @"quotes.json";
            using (StreamReader sr = new StreamReader(cFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    MegaDeskQuotes jsonList = JsonConvert.DeserializeObject<MegaDeskQuotes>(line);

                    //textBox1.Text += (jsonList.mdOrderDate.ToString("dd MMM yyyy") + " " +jsonList.mdLastName + " " + jsonList.mdFirstName) + "\r\n";

                    //listQuotes.Items.Add(new ListViewItem(new[]
                    //{
                    //    jsonList.mdOrderDate.ToString("dd MMM yyyy"),
                    //    jsonList.mdLastName,
                    //    jsonList.mdFirstName,
                    //    jsonList.mdDeskType,
                    //    jsonList.mdWidth.ToString(),
                    //    jsonList.mdDepth.ToString(),
                    //    jsonList.mdNumOfDrawers.ToString()
                    //}));

                    string[] row = new string[] 
                    {
                        jsonList.mdOrderDate.ToString("dd MMM yyyy"),
                        jsonList.mdLastName,
                        jsonList.mdFirstName,
                        jsonList.mdDeskType,
                        jsonList.mdWidth.ToString(),
                        jsonList.mdDepth.ToString(),
                        jsonList.mdNumOfDrawers.ToString() };
                    gridQuotes.Rows.Add(row);

                }
            }


        }



        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu vewMainMenu = (MainMenu)Tag;
            vewMainMenu.Show();
            Close();
        }
    }
}
