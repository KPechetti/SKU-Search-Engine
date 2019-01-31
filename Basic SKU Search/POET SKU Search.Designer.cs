namespace Basic_SKU_Search
{
    partial class Form2
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
            this.PoetResult = new System.Windows.Forms.DataGridView();
            this.PoetSearch = new System.Windows.Forms.Button();
            this.PoetProgramOfferings = new System.Windows.Forms.ComboBox();
            this.PoetLicAgreementType = new System.Windows.Forms.ComboBox();
            this.PoetOfferingLevel = new System.Windows.Forms.ComboBox();
            this.PoetProgram = new System.Windows.Forms.ComboBox();
            this.PoetCustomerType = new System.Windows.Forms.ComboBox();
            this.PoetCountry = new System.Windows.Forms.ComboBox();
            this.PoetOrder = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PoetWait = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PoetResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PoetResult
            // 
            this.PoetResult.BackgroundColor = System.Drawing.Color.White;
            this.PoetResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PoetResult.Location = new System.Drawing.Point(337, 104);
            this.PoetResult.Name = "PoetResult";
            this.PoetResult.Size = new System.Drawing.Size(779, 274);
            this.PoetResult.TabIndex = 30;
            // 
            // PoetSearch
            // 
            this.PoetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PoetSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoetSearch.ForeColor = System.Drawing.Color.White;
            this.PoetSearch.Location = new System.Drawing.Point(193, 403);
            this.PoetSearch.Name = "PoetSearch";
            this.PoetSearch.Size = new System.Drawing.Size(75, 23);
            this.PoetSearch.TabIndex = 29;
            this.PoetSearch.Text = "Search";
            this.PoetSearch.UseVisualStyleBackColor = true;
            this.PoetSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // PoetProgramOfferings
            // 
            this.PoetProgramOfferings.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PoetProgramOfferings.FormattingEnabled = true;
            this.PoetProgramOfferings.Items.AddRange(new object[] {
            "ACP",
            "ALN",
            "CTC",
            "CUS",
            "EAP",
            "ECI",
            "ELP",
            "ESP",
            "EXC",
            "FAC",
            "FUL",
            "ITA",
            "MCP",
            "MCT",
            "NON",
            "PDO",
            "PLA",
            "PLU",
            "PRD",
            "PRM",
            "SCE",
            "STD",
            "STU",
            "TEL",
            "UTD",
            "VLP",
            "W20",
            "W95",
            "W98",
            "WME",
            "WXP"});
            this.PoetProgramOfferings.Location = new System.Drawing.Point(193, 312);
            this.PoetProgramOfferings.Name = "PoetProgramOfferings";
            this.PoetProgramOfferings.Size = new System.Drawing.Size(121, 21);
            this.PoetProgramOfferings.TabIndex = 28;
            // 
            // PoetLicAgreementType
            // 
            this.PoetLicAgreementType.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PoetLicAgreementType.FormattingEnabled = true;
            this.PoetLicAgreementType.Items.AddRange(new object[] {
            "Commercial",
            "Corporate",
            "Academic",
            "Government",
            "Local Government",
            "Non-specific"});
            this.PoetLicAgreementType.Location = new System.Drawing.Point(193, 270);
            this.PoetLicAgreementType.Name = "PoetLicAgreementType";
            this.PoetLicAgreementType.Size = new System.Drawing.Size(121, 21);
            this.PoetLicAgreementType.TabIndex = 26;
            // 
            // PoetOfferingLevel
            // 
            this.PoetOfferingLevel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PoetOfferingLevel.FormattingEnabled = true;
            this.PoetOfferingLevel.Items.AddRange(new object[] {
            "0  ",
            "A  ",
            "B  ",
            "C  ",
            "D  ",
            "E  ",
            "F  ",
            "NON"});
            this.PoetOfferingLevel.Location = new System.Drawing.Point(193, 357);
            this.PoetOfferingLevel.Name = "PoetOfferingLevel";
            this.PoetOfferingLevel.Size = new System.Drawing.Size(121, 21);
            this.PoetOfferingLevel.TabIndex = 24;
            // 
            // PoetProgram
            // 
            this.PoetProgram.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PoetProgram.FormattingEnabled = true;
            this.PoetProgram.Items.AddRange(new object[] {
            "SPLA",
            "Asia Government",
            "ASP",
            "Enterprise Annuity Subscription",
            "Commercial",
            "Online Services Premium Agmt",
            "Campus 1",
            "Campus 2",
            "Campus 3",
            "CSP",
            "Enterprise 100",
            "Enterprise Annuity 2.0",
            "Enterprise 5",
            "Enterprise 6",
            "Enterprise Subscription 1",
            "ENTERPRISE SUBSCRIPTION",
            "Enterprise Subscription 6",
            "FPP",
            "Fulfillment",
            "Games On Demand",
            "Get Genuine Agreement",
            "GIA",
            "Government Open Annuity",
            "Hosted Pilot",
            "HVMS",
            "ISV 3",
            "ISV",
            "MSDN 1 Month",
            "MCIS",
            "Multi Year Open",
            "Non-specific",
            "OSL 6",
            "Open Value",
            "OSL 1",
            "OSL",
            "Open Value Subscription",
            "UK Govt Private Finance",
            "PIP",
            "Referral",
            "Select 3",
            "Select 4",
            "Select 5",
            "Select 6",
            "School 1",
            "School 3",
            "SELECT",
            "Select Local",
            "Select Plus",
            "SMB Promo",
            "Special Agreement",
            "Services Agreement",
            "US Government",
            "Volume Subscription 6",
            "Open License Value",
            "VBA",
            "VSIP"});
            this.PoetProgram.Location = new System.Drawing.Point(193, 183);
            this.PoetProgram.Name = "PoetProgram";
            this.PoetProgram.Size = new System.Drawing.Size(121, 21);
            this.PoetProgram.TabIndex = 22;
            // 
            // PoetCustomerType
            // 
            this.PoetCustomerType.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PoetCustomerType.FormattingEnabled = true;
            this.PoetCustomerType.Items.AddRange(new object[] {
            "Authorized License Provider",
            "Direct to ASP",
            "Direct To CSP",
            "Distributor",
            "Fulfillment No Charge",
            "Direct To ISV",
            "Direct To Reseller",
            "Direct To End User"});
            this.PoetCustomerType.Location = new System.Drawing.Point(193, 227);
            this.PoetCustomerType.Name = "PoetCustomerType";
            this.PoetCustomerType.Size = new System.Drawing.Size(121, 21);
            this.PoetCustomerType.TabIndex = 20;
            // 
            // PoetCountry
            // 
            this.PoetCountry.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PoetCountry.FormattingEnabled = true;
            this.PoetCountry.Items.AddRange(new object[] {
            "Andorra",
            "United Arab Emirates",
            "Afghanistan",
            "Antigua and Barbuda",
            "Anguilla",
            "Albania",
            "Armenia",
            "Netherlands Antilles",
            "Angola",
            "Antarctica",
            "Argentina",
            "American Samoa",
            "Austria",
            "Australia",
            "Aruba",
            "Azerbaijan",
            "Bosnia and Herzegovina",
            "Barbados",
            "Bangladesh",
            "Belgium",
            "Burkina Faso",
            "Bulgaria",
            "Bahrain",
            "Burundi",
            "Benin",
            "Bermuda",
            "Brunei",
            "Bolivia",
            "Brazil",
            "Bahamas",
            "Bhutan",
            "Bouvet Island",
            "Botswana",
            "Belarus",
            "Belize",
            "Canada",
            "Cocos (Keeling) Islands",
            "Congo (DRC)",
            "Central African Republic",
            "Congo",
            "Switzerland",
            "Cote d’Ivoire",
            "Cook Islands",
            "Chile",
            "Cameroon",
            "China",
            "Colombia",
            "Costa Rica",
            "Cuba",
            "Cabo Verde",
            "Christmas Island",
            "Cyprus",
            "Czech Republic",
            "Germany",
            "Djibouti",
            "Denmark",
            "Dominica",
            "Dominican Republic",
            "Algeria",
            "Ecuador",
            "Estonia",
            "Egypt",
            "Eritrea",
            "Spain",
            "Ethiopia",
            "Finland",
            "Fiji Islands",
            "Falkland Islands",
            "Micronesia",
            "Faroe Islands",
            "France",
            "Gabon",
            "United Kingdom",
            "Grenada",
            "Georgia",
            "French Guiana",
            "Ghana",
            "Gibraltar",
            "Greenland",
            "Gambia",
            "Guinea",
            "Guadeloupe",
            "Equatorial Guinea",
            "Greece",
            "Guatemala",
            "Guam",
            "Guinea-Bissau",
            "Guyana",
            "Hong Kong SAR",
            "Heard Island And McDonald Islands",
            "Honduras",
            "Croatia",
            "Haiti",
            "Hungary",
            "Indonesia",
            "Ireland",
            "Israel",
            "India",
            "British Indian Ocean Territory",
            "Iraq",
            "Iran",
            "Iceland",
            "Italy",
            "Jamaica",
            "Jordan",
            "Japan",
            "Kenya",
            "Kyrgyzstan",
            "Cambodia",
            "Kiribati",
            "Comoros",
            "Saint Kitts and Nevis",
            "North Korea",
            "Korea",
            "Kuwait",
            "Cayman Islands",
            "Kazakhstan",
            "Laos",
            "Lebanon",
            "Saint Lucia",
            "Liechtenstein",
            "Sri Lanka",
            "Liberia",
            "Lesotho",
            "Lithuania",
            "Luxembourg",
            "Latvia",
            "Libya",
            "Morocco",
            "Monaco",
            "Moldova",
            "Montenegro",
            "Madagascar",
            "Marshall Islands",
            "Macedonia",
            "Mali",
            "Myanmar",
            "Mongolia",
            "Macao",
            "Northern Mariana Islands",
            "Martinique",
            "Mauritania",
            "Montserrat",
            "Malta",
            "Mauritius",
            "Maldives",
            "Malawi",
            "Mexico",
            "Malaysia",
            "Mozambique",
            "Namibia",
            "New Caledonia",
            "Niger",
            "Norfolk Island",
            "Nigeria",
            "Nicaragua",
            "Netherlands, The",
            "Norway",
            "Nepal",
            "Nauru",
            "Niue",
            "New Zealand",
            "Oman",
            "Panama",
            "Peru",
            "French Polynesia",
            "Papua New Guinea",
            "Philippines",
            "Pakistan",
            "Poland",
            "Saint Pierre and Miquelon",
            "Pitcairn Islands",
            "Puerto Rico",
            "Palestinian Authority",
            "Portugal",
            "Palau",
            "Paraguay",
            "Qatar",
            "Reunion",
            "Romania",
            "Serbia",
            "Russia",
            "Rwanda",
            "Saudi Arabia",
            "Solomon Islands",
            "Seychelles",
            "Sudan",
            "Sweden",
            "Singapore",
            "Saint Helena",
            "Slovenia",
            "Svalbard and Jan Mayen",
            "Slovakia",
            "Sierra Leone",
            "San Marino",
            "Senegal",
            "Somalia",
            "Suriname",
            "South Sudan",
            "Sao Tome and Principe",
            "El Salvador",
            "Syria",
            "Swaziland",
            "Turks and Caicos Islands",
            "Chad",
            "French Southern and Antarctic Lands",
            "Togo",
            "Thailand",
            "Tajikistan",
            "Tokelau",
            "Timor-Leste",
            "Turkmenistan",
            "Tunisia",
            "Tonga",
            "Turkey",
            "Trinidad and Tobago",
            "Tuvalu",
            "Taiwan",
            "Tanzania",
            "Ukraine",
            "Uganda",
            "U.S. Outlying Islands",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vatican City",
            "Saint Vincent and The Grenadines",
            "Venezuela",
            "Virgin Islands, British",
            "U.S. Virgin Islands",
            "Vietnam",
            "Vanuatu",
            "Wallis and Futuna",
            "Samoa",
            "Kosovo",
            "Yemen",
            "Mayotte",
            "South Africa",
            "Zambia",
            "Zimbabwe"});
            this.PoetCountry.Location = new System.Drawing.Point(193, 142);
            this.PoetCountry.Name = "PoetCountry";
            this.PoetCountry.Size = new System.Drawing.Size(121, 21);
            this.PoetCountry.TabIndex = 18;
            // 
            // PoetOrder
            // 
            this.PoetOrder.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PoetOrder.FormattingEnabled = true;
            this.PoetOrder.Items.AddRange(new object[] {
            "StepUp Order",
            "TrueUp Order",
            "Additional Products",
            "Reservation Order",
            "Transition Order"});
            this.PoetOrder.Location = new System.Drawing.Point(193, 104);
            this.PoetOrder.Name = "PoetOrder";
            this.PoetOrder.Size = new System.Drawing.Size(121, 21);
            this.PoetOrder.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Order Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Program";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Customer Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "License Agreement Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "Program Offerings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Offering Level Code";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Basic_SKU_Search.Properties.Resources.MS1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(689, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 39);
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Basic_SKU_Search.Properties.Resources.New_Micro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(696, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 39);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Basic_SKU_Search.Properties.Resources.MS_Logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(641, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 39);
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Basic_SKU_Search.Properties.Resources.New_CR;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(523, 440);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(268, 39);
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // PoetWait
            // 
            this.PoetWait.AutoSize = true;
            this.PoetWait.BackColor = System.Drawing.Color.SlateGray;
            this.PoetWait.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoetWait.ForeColor = System.Drawing.Color.White;
            this.PoetWait.Location = new System.Drawing.Point(466, 216);
            this.PoetWait.Name = "PoetWait";
            this.PoetWait.Size = new System.Drawing.Size(126, 15);
            this.PoetWait.TabIndex = 50;
            this.PoetWait.Text = "Please wait..Loading...";
            this.PoetWait.Click += new System.EventHandler(this.PoetWait_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(242, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 31);
            this.label9.TabIndex = 51;
            this.label9.Text = "POET SKU SEARCH";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Basic_SKU_Search.Properties.Resources.hh;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(33, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 37);
            this.button2.TabIndex = 52;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(816, 491);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PoetWait);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PoetOrder);
            this.Controls.Add(this.PoetResult);
            this.Controls.Add(this.PoetSearch);
            this.Controls.Add(this.PoetProgramOfferings);
            this.Controls.Add(this.PoetLicAgreementType);
            this.Controls.Add(this.PoetOfferingLevel);
            this.Controls.Add(this.PoetProgram);
            this.Controls.Add(this.PoetCustomerType);
            this.Controls.Add(this.PoetCountry);
            this.Name = "Form2";
            this.Text = "POET SKU Search";
            ((System.ComponentModel.ISupportInitialize)(this.PoetResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PoetResult;
        private System.Windows.Forms.Button PoetSearch;
        private System.Windows.Forms.ComboBox PoetProgramOfferings;
        private System.Windows.Forms.ComboBox PoetLicAgreementType;
        private System.Windows.Forms.ComboBox PoetOfferingLevel;
        private System.Windows.Forms.ComboBox PoetProgram;
        private System.Windows.Forms.ComboBox PoetCustomerType;
        private System.Windows.Forms.ComboBox PoetCountry;
        private System.Windows.Forms.ComboBox PoetOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label PoetWait;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
    }
}