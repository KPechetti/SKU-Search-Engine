namespace Basic_SKU_Search
{
    partial class MOET_Sku_Search
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
            this.Currency = new System.Windows.Forms.ComboBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.MoetCusType = new System.Windows.Forms.ComboBox();
            this.MoetOrder = new System.Windows.Forms.ComboBox();
            this.MoetResult = new System.Windows.Forms.DataGridView();
            this.MoetSearch = new System.Windows.Forms.Button();
            this.CustomerNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MoetWait = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoetResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Currency
            // 
            this.Currency.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Currency.FormattingEnabled = true;
            this.Currency.Items.AddRange(new object[] {
            "ATS",
            "AUD",
            "BDT",
            "BEF",
            "BTN",
            "CAD",
            "CHF",
            "DEM",
            "DKK",
            "ESP",
            "EUR",
            "FIM",
            "FRF",
            "GBP",
            "ITL",
            "JPY",
            "KRW",
            "LKR",
            "MVR",
            "NLG",
            "NOK",
            "NZD",
            "PTE",
            "SEK",
            "TWD",
            "USD"});
            this.Currency.Location = new System.Drawing.Point(201, 274);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(134, 21);
            this.Currency.TabIndex = 24;
            // 
            // Country
            // 
            this.Country.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Country.FormattingEnabled = true;
            this.Country.Items.AddRange(new object[] {
            "Afghanistan",
            "Africa New Markets",
            "Albania",
            "Algeria",
            "Angola",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahrain",
            "Bangladesh",
            "BCCBBJ",
            "Belarus",
            "Belgium",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Cambodia",
            "Canada",
            "Central Asia",
            "Chile",
            "China",
            "Colombia",
            "Costa Rica",
            "Croatia",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Dominican Republic",
            "Eastern Europe",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "EMEA HQ",
            "Estonia",
            "Finland",
            "France",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Guatemala",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indian Ocean Islands",
            "Indonesia",
            "InterCompany SalesOffice",
            "Iran",
            "Iraq",
            "Ireland Sales & Mktg",
            "Israel",
            "Italy",
            "Jamaica - Obsolete FY15",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Korea",
            "Kosovo",
            "Kuwait",
            "Latin America Other",
            "Latvia",
            "Lebanon",
            "Libya",
            "Lithuania",
            "Luxembourg",
            "Macedonia (FYROM)",
            "Malaysia",
            "Maldives",
            "Malta",
            "Mexico",
            "Moldova",
            "Montenegro",
            "Morocco",
            "Myanmar",
            "NEPA New Markets",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nigeria",
            "Norway",
            "Oman",
            "Other Middle East",
            "Other N.W. Africa",
            "Pakistan",
            "Panama",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Rest of East & Southern Africa",
            "Romania",
            "Russia",
            "Saudi Arabia",
            "Serbia",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "South Africa",
            "South East Asia Multi Country",
            "Spain",
            "Sri Lanka",
            "Sweden",
            "Switzerland",
            "Taiwan",
            "Thailand",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Venezuela",
            "Vietnam",
            "West and Central Africa"});
            this.Country.Location = new System.Drawing.Point(201, 145);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(134, 21);
            this.Country.TabIndex = 18;
            // 
            // MoetCusType
            // 
            this.MoetCusType.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MoetCusType.FormattingEnabled = true;
            this.MoetCusType.Items.AddRange(new object[] {
            "AFF",
            "DIS",
            "END",
            "LAR",
            "RSL"});
            this.MoetCusType.Location = new System.Drawing.Point(201, 189);
            this.MoetCusType.Name = "MoetCusType";
            this.MoetCusType.Size = new System.Drawing.Size(134, 21);
            this.MoetCusType.TabIndex = 16;
            // 
            // MoetOrder
            // 
            this.MoetOrder.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MoetOrder.FormattingEnabled = true;
            this.MoetOrder.Items.AddRange(new object[] {
            "FPP Order",
            "Open Business Order",
            "Open Business +500 Order"});
            this.MoetOrder.Location = new System.Drawing.Point(201, 104);
            this.MoetOrder.Name = "MoetOrder";
            this.MoetOrder.Size = new System.Drawing.Size(134, 21);
            this.MoetOrder.TabIndex = 14;
            this.MoetOrder.SelectedIndexChanged += new System.EventHandler(this.Country_SelectedIndexChanged);
            // 
            // MoetResult
            // 
            this.MoetResult.BackgroundColor = System.Drawing.Color.White;
            this.MoetResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoetResult.Location = new System.Drawing.Point(364, 104);
            this.MoetResult.Name = "MoetResult";
            this.MoetResult.Size = new System.Drawing.Size(625, 240);
            this.MoetResult.TabIndex = 25;
            this.MoetResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MoetSearch
            // 
            this.MoetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoetSearch.ForeColor = System.Drawing.Color.White;
            this.MoetSearch.Location = new System.Drawing.Point(201, 321);
            this.MoetSearch.Name = "MoetSearch";
            this.MoetSearch.Size = new System.Drawing.Size(75, 23);
            this.MoetSearch.TabIndex = 26;
            this.MoetSearch.Text = "Search";
            this.MoetSearch.UseVisualStyleBackColor = true;
            this.MoetSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CustomerNumber.Location = new System.Drawing.Point(201, 232);
            this.CustomerNumber.Name = "CustomerNumber";
            this.CustomerNumber.Size = new System.Drawing.Size(134, 20);
            this.CustomerNumber.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Order Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Customer Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "Customer Number (SAP ID)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Currency";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Basic_SKU_Search.Properties.Resources.MS1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(681, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 39);
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Basic_SKU_Search.Properties.Resources.MS_Logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(633, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 39);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Basic_SKU_Search.Properties.Resources.New_CR;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(522, 429);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(268, 39);
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Basic_SKU_Search.Properties.Resources.hh;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(29, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 37);
            this.button2.TabIndex = 53;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 54;
            this.label1.Text = "MOET SKU SEARCH";
            // 
            // MoetWait
            // 
            this.MoetWait.AutoSize = true;
            this.MoetWait.BackColor = System.Drawing.Color.SlateGray;
            this.MoetWait.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoetWait.ForeColor = System.Drawing.Color.White;
            this.MoetWait.Location = new System.Drawing.Point(483, 195);
            this.MoetWait.Name = "MoetWait";
            this.MoetWait.Size = new System.Drawing.Size(126, 15);
            this.MoetWait.TabIndex = 55;
            this.MoetWait.Text = "Please wait..Loading...";
            // 
            // MOET_Sku_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(804, 480);
            this.Controls.Add(this.MoetWait);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerNumber);
            this.Controls.Add(this.MoetSearch);
            this.Controls.Add(this.MoetResult);
            this.Controls.Add(this.Currency);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.MoetCusType);
            this.Controls.Add(this.MoetOrder);
            this.Name = "MOET_Sku_Search";
            this.Text = "                                          MOET_SKU_Search";
            this.Load += new System.EventHandler(this.MOET_Sku_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoetResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Currency;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.ComboBox MoetCusType;
        private System.Windows.Forms.ComboBox MoetOrder;
        private System.Windows.Forms.DataGridView MoetResult;
        private System.Windows.Forms.Button MoetSearch;
        private System.Windows.Forms.TextBox CustomerNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MoetWait;
    }
}