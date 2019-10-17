using System;

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

        /*string fName, string lName, string addrss, string cty, string stte,
        float width, float depth, float drawers, string materials, float rush*/

        public static void DeskCost(ref Desk testDesk, ref DeskQuote testQuote, ref DisplayQuotes viewDisplayQuotes)
        {
            // Variables
            float squareInch, feeRush = 0, matFee = 0, drawFee, topfee = 0, deskCost, width, depth, drawers;
            string descOut, breakCost, fName, lName, addrss, cty, rush, materials, stte;
            DateTime orderDate;

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
            

            // Math to follow
            // Figure square feet
            squareInch = depth * width;
            // Drawer fee math
            drawFee = (float)MegaConst.DrawerPrice * drawers;
            
            // Logic
            // Check for Rush
            if (rush != RushDays.Fourteen.ToString())
            {
                feeRush = RushFee(squareInch, rush);
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

            // Add it all up
            deskCost = feeRush + matFee + drawFee + topfee + (float)MegaConst.BaseDeskPrice;

            // Description for output
            descOut = "Your desk is " + width + " inches wide, the depth is " + depth + " inches, \nit is built out of " + materials +
                      ", has " + drawers + " drawers, \nand it will be built in " + rush + " days.";
            breakCost = "Base desk Price: $" + (float)MegaConst.BaseDeskPrice + ".\nMaterial Fee: $" + matFee + 
                        ".\nDrawer fee: $" + drawFee + ".\nSize Fee: $" + topfee + ".\nRush Fee: $" + feeRush;

            viewDisplayQuotes.FirstNameLabel.Text = fName;
            viewDisplayQuotes.LastNameLabel.Text = lName;
            viewDisplayQuotes.AddressLabel.Text = addrss;
            viewDisplayQuotes.CityLabel.Text = cty + @", ";
            viewDisplayQuotes.StateLabel.Text = stte;
            //viewDisplayQuotes.DeskDiscLabel.Text = descOut + ":";
            viewDisplayQuotes.MaterialLabel.Text = materials;
            viewDisplayQuotes.WidthLabel.Text = width.ToString();
            viewDisplayQuotes.DepthLabel.Text = depth.ToString();
            viewDisplayQuotes.DrawersLabel.Text = drawers.ToString();
            viewDisplayQuotes.DaysLabel.Text = rush.ToString();
            //viewDisplayQuotes.Desk1.Text = breakCost;
            //viewDisplayQuotes.Desk2.Text = "Total Cost:      $" + deskCost;
            viewDisplayQuotes.BaseDeskPriceLabel.Text = "200";
            viewDisplayQuotes.MaterialFeeLabel.Text = matFee.ToString();
            viewDisplayQuotes.DrawerFeeLabel.Text = drawFee.ToString();
            viewDisplayQuotes.OversizeFeeLabel.Text = topfee.ToString();
            viewDisplayQuotes.RushFeeLabel.Text = feeRush.ToString();
            viewDisplayQuotes.TotalCostLabel.Text = "$" + deskCost.ToString();
        }

        private static float RushFee(float squareInch, string rush)
        {
            // Variables and array of fees
            float fee;
            int[,] rushFee = { { 60, 70, 80 }, { 40, 50, 60 }, { 30, 35, 40 } };
            int[] squareRange = { 1000, 2000 };

            // logic for fee
            if (squareInch < squareRange[0])
            {
                // Return 3 day fee
                if (rush == RushDays.Three.ToString())
                {
                    fee = rushFee[0, 0];
                }
                // Return 5 day fee
                else if (rush == RushDays.Five.ToString())
                {
                    fee = rushFee[1, 0];
                }
                // Return 7 day fee
                else
                {
                    fee = rushFee[2, 0];
                }
            }
            else if (squareInch > squareRange[1])
            {
                if (rush == RushDays.Three.ToString())
                {
                    fee = rushFee[0, 2];
                }
                else if (rush == RushDays.Five.ToString())
                {
                    fee = rushFee[1, 2];
                }
                else
                {
                    fee = rushFee[2, 2];
                }
            }
            else
            {
                if (rush == RushDays.Three.ToString())
                {
                    fee = rushFee[0, 1];
                }
                else if (rush == RushDays.Five.ToString())
                {
                    fee = rushFee[1, 1];
                }
                else
                {
                    fee = rushFee[2, 1];
                }
            }
            // return fee
            return fee;
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
        //public string mdTotalCost { get; set; }
        //public string mdBreakCost { get; set; }
    }
}
