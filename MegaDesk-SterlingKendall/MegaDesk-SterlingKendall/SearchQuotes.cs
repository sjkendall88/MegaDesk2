﻿using System;
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
            searchGridView.Rows.Clear();
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            // Get Selected desktype
            string selectMaterial = searchComboBox.Text;

            // Clear text from prior search
            searchGridView.Rows.Clear();
            searchResult.Text = "";

            // Catch exception for file reader
            try
            {
                // Create method to search JSON file with saved Quotes
                StreamReader readFile = new StreamReader(@"quotes.json");


                while (readFile.EndOfStream == false)
                {
                    // loop through file looking for selected material type
                    string line = readFile.ReadLine();
                    MegaDeskQuotes outDeskQuotes = JsonConvert.DeserializeObject<MegaDeskQuotes>(line);

                    // Catch exception for material type not found
                    try
                    {
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
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }
                }

                // Close reader
                readFile.Close();

                // Check for rows added // if not added out failure // if successful out Results
                int rowCount = searchGridView.Rows.Count;
                searchResult.Text = rowCount > 1 ? "" : "No records found  for " + selectMaterial + ".";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
