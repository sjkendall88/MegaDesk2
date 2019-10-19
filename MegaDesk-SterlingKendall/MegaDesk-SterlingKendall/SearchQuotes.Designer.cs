namespace MegaDesk2_TeamEternal
{
    partial class SearchQuotes
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
            this.components = new System.ComponentModel.Container();
            this.BackButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchResult = new System.Windows.Forms.Label();
            this.deskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewQuoteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(817, 493);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(155, 56);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Main Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // subButton
            // 
            this.subButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subButton.Location = new System.Drawing.Point(327, 76);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(88, 31);
            this.subButton.TabIndex = 6;
            this.subButton.Text = "Search";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(200, 85);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(52, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search By Material";
            // 
            // searchGridView
            // 
            this.searchGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.searchGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fName,
            this.lName,
            this.qDate,
            this.dWidth,
            this.dDepth,
            this.dMaterial,
            this.dDrawers,
            this.rOrder,
            this.tCost});
            this.searchGridView.Location = new System.Drawing.Point(19, 135);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.Size = new System.Drawing.Size(943, 331);
            this.searchGridView.TabIndex = 9;
            // 
            // fName
            // 
            this.fName.HeaderText = "First Name";
            this.fName.Name = "fName";
            // 
            // lName
            // 
            this.lName.HeaderText = "Last Name";
            this.lName.Name = "lName";
            // 
            // qDate
            // 
            this.qDate.HeaderText = "Quote Date";
            this.qDate.Name = "qDate";
            // 
            // dWidth
            // 
            this.dWidth.HeaderText = "Desk Width";
            this.dWidth.Name = "dWidth";
            // 
            // dDepth
            // 
            this.dDepth.HeaderText = "Desk Depth";
            this.dDepth.Name = "dDepth";
            // 
            // dMaterial
            // 
            this.dMaterial.HeaderText = "Desk Material";
            this.dMaterial.Name = "dMaterial";
            // 
            // dDrawers
            // 
            this.dDrawers.HeaderText = "Desk Drawers";
            this.dDrawers.Name = "dDrawers";
            // 
            // rOrder
            // 
            this.rOrder.HeaderText = "Rush Order";
            this.rOrder.Name = "rOrder";
            // 
            // tCost
            // 
            this.tCost.HeaderText = "Total Cost";
            this.tCost.Name = "tCost";
            // 
            // searchResult
            // 
            this.searchResult.AutoSize = true;
            this.searchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResult.ForeColor = System.Drawing.SystemColors.Control;
            this.searchResult.Location = new System.Drawing.Point(623, 86);
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(0, 20);
            this.searchResult.TabIndex = 11;
            // 
            // NewQuoteLabel
            // 
            this.NewQuoteLabel.AutoSize = true;
            this.NewQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewQuoteLabel.ForeColor = System.Drawing.Color.White;
            this.NewQuoteLabel.Location = new System.Drawing.Point(330, 9);
            this.NewQuoteLabel.Name = "NewQuoteLabel";
            this.NewQuoteLabel.Size = new System.Drawing.Size(359, 31);
            this.NewQuoteLabel.TabIndex = 73;
            this.NewQuoteLabel.Text = "Search Quotes by Material";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.NewQuoteLabel);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.searchGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.BackButton);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.BindingSource deskBindingSource;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCost;
        private System.Windows.Forms.Label searchResult;
        private System.Windows.Forms.Label NewQuoteLabel;
    }
}