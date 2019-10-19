namespace MegaDesk2_TeamEternal
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AddNewQuote = new System.Windows.Forms.Button();
            this.ViewQuote = new System.Windows.Forms.Button();
            this.SearchQuote = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.MegaDeskLogo = new System.Windows.Forms.PictureBox();
            this.MainMenuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MegaDeskLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewQuote
            // 
            this.AddNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewQuote.Location = new System.Drawing.Point(172, 124);
            this.AddNewQuote.Name = "AddNewQuote";
            this.AddNewQuote.Size = new System.Drawing.Size(155, 56);
            this.AddNewQuote.TabIndex = 0;
            this.AddNewQuote.Text = "&Add New Quote";
            this.AddNewQuote.UseVisualStyleBackColor = true;
            this.AddNewQuote.Click += new System.EventHandler(this.AddNewQuote_Click);
            // 
            // ViewQuote
            // 
            this.ViewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuote.Location = new System.Drawing.Point(172, 205);
            this.ViewQuote.Name = "ViewQuote";
            this.ViewQuote.Size = new System.Drawing.Size(155, 56);
            this.ViewQuote.TabIndex = 1;
            this.ViewQuote.Text = "&View Quotes";
            this.ViewQuote.UseVisualStyleBackColor = true;
            this.ViewQuote.Click += new System.EventHandler(this.ViewQuote_Click);
            // 
            // SearchQuote
            // 
            this.SearchQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuote.Location = new System.Drawing.Point(172, 286);
            this.SearchQuote.Name = "SearchQuote";
            this.SearchQuote.Size = new System.Drawing.Size(155, 56);
            this.SearchQuote.TabIndex = 2;
            this.SearchQuote.Text = "&Search Quote";
            this.SearchQuote.UseVisualStyleBackColor = true;
            this.SearchQuote.Click += new System.EventHandler(this.SearchQuote_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(172, 367);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(155, 56);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MegaDeskLogo
            // 
            this.MegaDeskLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MegaDeskLogo.Image = ((System.Drawing.Image)(resources.GetObject("MegaDeskLogo.Image")));
            this.MegaDeskLogo.Location = new System.Drawing.Point(445, 111);
            this.MegaDeskLogo.Name = "MegaDeskLogo";
            this.MegaDeskLogo.Size = new System.Drawing.Size(441, 333);
            this.MegaDeskLogo.TabIndex = 4;
            this.MegaDeskLogo.TabStop = false;
            // 
            // MainMenuLabel
            // 
            this.MainMenuLabel.AutoSize = true;
            this.MainMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuLabel.ForeColor = System.Drawing.Color.White;
            this.MainMenuLabel.Location = new System.Drawing.Point(411, 9);
            this.MainMenuLabel.Name = "MainMenuLabel";
            this.MainMenuLabel.Size = new System.Drawing.Size(155, 31);
            this.MainMenuLabel.TabIndex = 5;
            this.MainMenuLabel.Text = "Main Menu";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.MainMenuLabel);
            this.Controls.Add(this.MegaDeskLogo);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SearchQuote);
            this.Controls.Add(this.ViewQuote);
            this.Controls.Add(this.AddNewQuote);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.MegaDeskLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewQuote;
        private System.Windows.Forms.Button ViewQuote;
        private System.Windows.Forms.Button SearchQuote;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox MegaDeskLogo;
        private System.Windows.Forms.Label MainMenuLabel;
    }
}

