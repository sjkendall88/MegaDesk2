using System;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk2_TeamEternal
{
    class DeskQuote
    {
        // Desk quote variables
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public DateTime orderDate = DateTime.Today;


        public static void DeskCost(ref Desk testDesk, ref DeskQuote testQuote, ref DisplayQuotes viewDisplayQuotes)
        {
            // Variables
            float squareInch, feeRush = 0, matFee = 0, exDays = 0, drawFee, topfee = 0, deskCost, width, depth, drawers, baseDeskPrice=(float)MegaConst.BaseDeskPrice;
            string fName, lName, addrss, cty, rush, materials, stte;
            DateTime orderDate, expDate = default;
            int[,] rushFee = new int[3, 3];

            //Assignment
            fName = testQuote.firstName;
            lName = testQuote.lastName;
            addrss = testQuote.address;
            cty = testQuote.city;
            stte = testQuote.state;
            orderDate = testQuote.orderDate;
            depth = testDesk.Depth;
            width = testDesk.Width;
            drawers = testDesk.NumOfDrawers;
            materials = testDesk.DeskType;
            rush = testDesk.RushDays;
            

            // Area
            squareInch = depth * width;
            // Drawer fee math
            drawFee = (float)MegaConst.DrawerPrice * drawers;

            // Load rush costs into array
            rushFee = GetRushOrder();

            // Logic
            // Check for Rush
            if (rush != RushDays.Fourteen.ToString())
            {
                (feeRush, exDays) = RushFee(squareInch, rush, rushFee);
            }
            else
            {
                feeRush = 0;
                exDays = 14;
            }

            // Check material fee
            switch (materials)
            {
                case "Oak":
                    matFee = (float)MegaConst.OakPrice;
                    break;
                case "Laminate":
                    matFee = (float)MegaConst.LaminatePrice;
                    break;
                case "Pine":
                    matFee = (float)MegaConst.PinePrice;
                    break;
                case "Rosewood":
                    matFee = (float)MegaConst.RosewoodPrice;
                    break;
                case "Veneer":
                    matFee = (float)MegaConst.VeneerPrice;
                    break;
            }

            // Check square foot fee
            if (squareInch > (float)MegaConst.BaseDeskSize)
            {
                topfee = (squareInch - (float)MegaConst.BaseDeskSize);
            }

            // Expected date math
            switch (rush)
            {
                case "Fourteen":
                    expDate = orderDate.AddDays(14);
                    break;
                case "Seven":
                    expDate = orderDate.AddDays(7);
                    break;
                case "Five":
                    expDate = orderDate.AddDays(5);
                    break;
                case "Three":
                    expDate = orderDate.AddDays(3);
                    break;
            }

            // Add it all up
            deskCost = feeRush + matFee + drawFee + topfee + baseDeskPrice;

            // Output for DisplayQuotes
            #region Output Display
            viewDisplayQuotes.FirstNameLabel.Text = fName;
            viewDisplayQuotes.LastNameLabel.Text = lName;
            viewDisplayQuotes.AddressLabel.Text = addrss;
            viewDisplayQuotes.CityLabel.Text = cty;
            viewDisplayQuotes.StateLabel.Text = stte;
            viewDisplayQuotes.MaterialLabel.Text = materials;
            viewDisplayQuotes.WidthLabel.Text = width.ToString();
            viewDisplayQuotes.DepthLabel.Text = depth.ToString();
            viewDisplayQuotes.DrawersLabel.Text = drawers.ToString();
            viewDisplayQuotes.DaysLabel.Text = exDays.ToString();
            viewDisplayQuotes.BaseDeskPriceLabel.Text = "$" + baseDeskPrice.ToString();
            viewDisplayQuotes.MaterialFeeLabel.Text = "$" + matFee.ToString();
            viewDisplayQuotes.DrawerFeeLabel.Text = "$" + drawFee.ToString();
            viewDisplayQuotes.OversizeFeeLabel.Text = "$" + topfee.ToString();
            viewDisplayQuotes.RushFeeLabel.Text = "$" + feeRush.ToString();
            viewDisplayQuotes.OrderDate.Text = orderDate.ToString("MMMM dd yyyy");
            viewDisplayQuotes.ExpectedDateLabel.Text = expDate.ToString("MMMM dd yyyy");
            viewDisplayQuotes.TotalCostLabel.Text = "$" + deskCost;
            #endregion

            MegaDeskQuotes megaDeskQuotes = new MegaDeskQuotes();

            megaDeskQuotes.mdFirstName = fName;
            megaDeskQuotes.mdLastName = lName;
            megaDeskQuotes.mdAddress = addrss;
            megaDeskQuotes.mdCity = cty;
            megaDeskQuotes.mdState = stte;
            megaDeskQuotes.mdOrderDate = orderDate;
            megaDeskQuotes.mdWidth = width;
            megaDeskQuotes.mdDepth = depth;
            megaDeskQuotes.mdNumOfDrawers = drawers;
            megaDeskQuotes.mdDeskType = materials;
            megaDeskQuotes.mdRushDays = rush;
            megaDeskQuotes.mdTotalCost = "$" + deskCost.ToString();


            string result = JsonConvert.SerializeObject(megaDeskQuotes);
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
        }

        private static (float fee, float exDays) RushFee(float squareInch, string rush, int[,] rushFee)
        {
            // Variables and array of fees
            float fee, exDays;
            int[] squareRange = { 1000, 2000 };

            // logic for fee
            if (squareInch < squareRange[0])
            {
                // Return 3 day fee
                if (rush == RushDays.Three.ToString())
                {
                    fee = rushFee[0, 0];
                    exDays = 3;
                }
                // Return 5 day fee
                else if (rush == RushDays.Five.ToString())
                {
                    fee = rushFee[1, 0];
                    exDays = 5;
                }
                // Return 7 day fee
                else
                {
                    fee = rushFee[2, 0];
                    exDays = 7;
                }
            }
            else if (squareInch > squareRange[1])
            {
                if (rush == RushDays.Three.ToString())
                {
                    fee = rushFee[0, 2];
                    exDays = 3;
                }
                else if (rush == RushDays.Five.ToString())
                {
                    fee = rushFee[1, 2];
                    exDays = 5;
                }
                else
                {
                    fee = rushFee[2, 2];
                    exDays = 7;
                }
            }
            else
            {
                if (rush == RushDays.Three.ToString())
                {
                    fee = rushFee[0, 1];
                    exDays = 3;
                }
                else if (rush == RushDays.Five.ToString())
                {
                    fee = rushFee[1, 1];
                    exDays = 5;
                }
                else
                {
                    fee = rushFee[2, 1];
                    exDays = 7;
                }
            }
            return (fee, exDays);
        }

        // create getRushOrder method to read values from file
        public static int[,] GetRushOrder()
        {
            try
            {
                // Array variable to return with values
                string filePath = @"rushOrderPrices.txt";
                int[,] rushFee = new int[3, 3];


                // read file
                string[] readFile = File.ReadAllLines(filePath);

                // for loop to populate multidimensional array
                int i = 0, x = 0, y = 0;

                while (i < readFile.Length)
                {
                    while (x < 3)
                    {
                        while (y < 3)
                        {

                            rushFee[x, y] = int.Parse(readFile[i]);

                            i++;
                            y++;
                        }
                        x++;
                        y = 0;
                    }
                }

                // variable to return array
                return rushFee;
                
            }
            catch (Exception e)
            {
                // Write file
                StreamWriter writeFile = new StreamWriter(@"rushOrderPrices.txt");

                // Variable to write file
                string priceString = "60\r\n70\r\n80\r\n40\r\n50\r\n60\r\n30\r\n35\r\n40";

                // Write file
                writeFile.WriteLine(priceString);

                // close file
                writeFile.Close();

                Console.WriteLine(e);

                // Call method again to populate array
                return GetRushOrder();
            }
        }
    }



    class MegaDeskQuotes //: DeskQuote
    {
        public string mdFirstName { get; set; }
        public string mdLastName { get; set; }
        public string mdAddress { get; set; }
        public string mdCity { get; set; }
        public string mdState { get; set; }
        public DateTime mdOrderDate { get; set; }
        public float mdWidth { get; set; }
        public float mdDepth { get; set; }
        public float mdNumOfDrawers { get; set; }
        public string mdDeskType { get; set; }
        public string mdRushDays { get; set; }
        public string mdTotalCost { get; set; }
    }
}
