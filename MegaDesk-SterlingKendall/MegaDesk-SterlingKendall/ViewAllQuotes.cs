using System;
using System.IO;
using System.Windows.Forms;
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

                    string[] row = new string[] 
                    {
                        jsonList.mdLastName,
                        jsonList.mdFirstName,
                        jsonList.mdOrderDate.ToString("dd MMM yyyy"),
                        jsonList.mdDeskType,
                        jsonList.mdWidth.ToString(),
                        jsonList.mdDepth.ToString(),
                        jsonList.mdNumOfDrawers.ToString(),
                        jsonList.mdTotalCost
                    };
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
