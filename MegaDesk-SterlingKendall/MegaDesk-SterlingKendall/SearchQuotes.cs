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
using Newtonsoft.Json;

namespace MegaDesk2_TeamEternal
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }



        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu vewMainMenu = (MainMenu)Tag;
            vewMainMenu.Show();
            Close();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            // Fill combobox with desk material type for search parameter
            searchComboBox.DataSource = Enum.GetValues(typeof(DeskType));
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            // Get Selected desktype
            string selectMaterial = searchComboBox.Text;
            
            // Create object for datagrid view May use megaDeskQuote object

            // Create method to search JSON file with saved Quotes
            StreamReader readFile = new StreamReader(@"quotes.json");
            while (readFile.EndOfStream == false)
            {
                // loop through file looking for selected material type
                string line = readFile.ReadLine();
                MegaDeskQuotes outDeskQuotes = JsonConvert.DeserializeObject<MegaDeskQuotes>(line);

                if (outDeskQuotes.mdDeskType != selectMaterial)
                {
                    // If type not found continue
                    continue;
                }
                else
                {
                    // If type found write line
                    string[] row = new string[]
                    {
                        outDeskQuotes.mdFirstName,
                        outDeskQuotes.mdLastName,
                        outDeskQuotes.mdOrderDate.ToString(),
                        outDeskQuotes.mdWidth.ToString(),
                        outDeskQuotes.mdDepth.ToString(),
                        outDeskQuotes.mdDeskType,
                        outDeskQuotes.mdNumOfDrawers.ToString(),
                        outDeskQuotes.mdRushDays,
                        outDeskQuotes.mdTotalCost
                    };
                    searchGridView.Rows.Add(row);
                }
            }

            // Close reader
            readFile.Close();

            // Create method to fill view with Quotes

        }
    }
}
