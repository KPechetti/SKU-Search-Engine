namespace Basic_SKU_Search
{
    partial class Open_Business_Customer_Search
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
            this.OpenResult = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenSearch = new System.Windows.Forms.Button();
            this.Currency = new System.Windows.Forms.ComboBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.OpenWait = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OpenResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenResult
            // 
            this.OpenResult.BackgroundColor = System.Drawing.Color.White;
            this.OpenResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OpenResult.Location = new System.Drawing.Point(289, 110);
            this.OpenResult.Name = "OpenResult";
            this.OpenResult.Size = new System.Drawing.Size(567, 187);
            this.OpenResult.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Basic_SKU_Search.Properties.Resources.CopyRight2;
            this.pictureBox3.Location = new System.Drawing.Point(504, 458);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(222, 44);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Basic_SKU_Search.Properties.Resources.MS1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(689, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 39);
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Basic_SKU_Search.Properties.Resources.MS_Logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(634, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 39);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Basic_SKU_Search.Properties.Resources.New_CR;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Location = new System.Drawing.Point(530, 388);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(268, 39);
            this.pictureBox5.TabIndex = 48;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Currency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "Country";
            // 
            // OpenSearch
            // 
            this.OpenSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenSearch.ForeColor = System.Drawing.Color.White;
            this.OpenSearch.Location = new System.Drawing.Point(143, 208);
            this.OpenSearch.Name = "OpenSearch";
            this.OpenSearch.Size = new System.Drawing.Size(75, 23);
            this.OpenSearch.TabIndex = 51;
            this.OpenSearch.Text = "Search";
            this.OpenSearch.UseVisualStyleBackColor = true;
            this.OpenSearch.Click += new System.EventHandler(this.Search_Click_1);
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
            this.Currency.Location = new System.Drawing.Point(143, 167);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(121, 21);
            this.Currency.TabIndex = 50;
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
            this.Country.Location = new System.Drawing.Point(143, 130);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(121, 21);
            this.Country.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(186, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 26);
            this.label2.TabIndex = 54;
            this.label2.Text = "OPEN BUSINESS CUSTOMER SEARCH";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Basic_SKU_Search.Properties.Resources.hh;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(45, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 37);
            this.button2.TabIndex = 55;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OpenWait
            // 
            this.OpenWait.AutoSize = true;
            this.OpenWait.BackColor = System.Drawing.Color.SlateGray;
            this.OpenWait.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenWait.ForeColor = System.Drawing.Color.White;
            this.OpenWait.Location = new System.Drawing.Point(429, 158);
            this.OpenWait.Name = "OpenWait";
            this.OpenWait.Size = new System.Drawing.Size(126, 15);
            this.OpenWait.TabIndex = 56;
            this.OpenWait.Text = "Please wait..Loading...";
            // 
            // Open_Business_Customer_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(812, 439);
            this.Controls.Add(this.OpenWait);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenSearch);
            this.Controls.Add(this.Currency);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.OpenResult);
            this.Name = "Open_Business_Customer_Search";
            this.Text = "Open_Business_Customer_Search";
            ((System.ComponentModel.ISupportInitialize)(this.OpenResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OpenResult;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenSearch;
        private System.Windows.Forms.ComboBox Currency;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label OpenWait;
    }
}