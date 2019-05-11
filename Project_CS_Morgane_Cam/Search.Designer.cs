namespace Project_CS_Morgane_Cam
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.resultSearch = new System.Windows.Forms.TextBox();
            this.checkedListCountry = new System.Windows.Forms.CheckedListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.validationTypeSearch = new System.Windows.Forms.Label();
            this.homePageLabel = new System.Windows.Forms.Label();
            this.typeSearchLabel = new System.Windows.Forms.Label();
            this.groupTypeSearch = new System.Windows.Forms.GroupBox();
            this.actorButton = new System.Windows.Forms.RadioButton();
            this.producerButton = new System.Windows.Forms.RadioButton();
            this.countryButton = new System.Windows.Forms.RadioButton();
            this.titleButton = new System.Windows.Forms.RadioButton();
            this.genreButton = new System.Windows.Forms.RadioButton();
            this.yearButton = new System.Windows.Forms.RadioButton();
            this.searchTitle = new System.Windows.Forms.Label();
            this.searchImage = new System.Windows.Forms.PictureBox();
            this.menuLabel = new System.Windows.Forms.Label();
            this.genreChoice = new System.Windows.Forms.ComboBox();
            this.yearChoice = new System.Windows.Forms.ComboBox();
            this.groupTypeSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchImage)).BeginInit();
            this.SuspendLayout();
            // 
            // resultSearch
            // 
            this.resultSearch.AcceptsReturn = true;
            this.resultSearch.AcceptsTab = true;
            this.resultSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultSearch.Location = new System.Drawing.Point(14, 170);
            this.resultSearch.Multiline = true;
            this.resultSearch.Name = "resultSearch";
            this.resultSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultSearch.Size = new System.Drawing.Size(545, 29);
            this.resultSearch.TabIndex = 37;
            this.resultSearch.Visible = false;
            // 
            // checkedListCountry
            // 
            this.checkedListCountry.BackColor = System.Drawing.Color.White;
            this.checkedListCountry.CheckOnClick = true;
            this.checkedListCountry.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListCountry.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.checkedListCountry.FormattingEnabled = true;
            this.checkedListCountry.Items.AddRange(new object[] {
            "Bulgaria",
            "Canada",
            "France",
            "Netherlands",
            "Norway",
            "Spain",
            "United Kingdom",
            "United States of America"});
            this.checkedListCountry.Location = new System.Drawing.Point(14, 125);
            this.checkedListCountry.Name = "checkedListCountry";
            this.checkedListCountry.Size = new System.Drawing.Size(175, 40);
            this.checkedListCountry.Sorted = true;
            this.checkedListCountry.TabIndex = 36;
            this.checkedListCountry.UseCompatibleTextRendering = true;
            this.checkedListCountry.Visible = false;
            this.checkedListCountry.SelectedIndexChanged += new System.EventHandler(this.checkedListCountry_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(14, 70);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(205, 23);
            this.textBox.TabIndex = 34;
            this.textBox.Visible = false;
            // 
            // validationTypeSearch
            // 
            this.validationTypeSearch.AutoSize = true;
            this.validationTypeSearch.BackColor = System.Drawing.Color.Transparent;
            this.validationTypeSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationTypeSearch.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.validationTypeSearch.Location = new System.Drawing.Point(122, 288);
            this.validationTypeSearch.Name = "validationTypeSearch";
            this.validationTypeSearch.Size = new System.Drawing.Size(57, 15);
            this.validationTypeSearch.TabIndex = 33;
            this.validationTypeSearch.Text = "Validate";
            this.validationTypeSearch.Visible = false;
            this.validationTypeSearch.Click += new System.EventHandler(this.validationTypeSearch_Click);
            // 
            // homePageLabel
            // 
            this.homePageLabel.AutoSize = true;
            this.homePageLabel.BackColor = System.Drawing.Color.Transparent;
            this.homePageLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.homePageLabel.Location = new System.Drawing.Point(481, 342);
            this.homePageLabel.Name = "homePageLabel";
            this.homePageLabel.Size = new System.Drawing.Size(78, 15);
            this.homePageLabel.TabIndex = 32;
            this.homePageLabel.Text = "Home page";
            this.homePageLabel.Click += new System.EventHandler(this.homePageLabel_Click);
            // 
            // typeSearchLabel
            // 
            this.typeSearchLabel.AutoSize = true;
            this.typeSearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeSearchLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeSearchLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.typeSearchLabel.Location = new System.Drawing.Point(12, 9);
            this.typeSearchLabel.Name = "typeSearchLabel";
            this.typeSearchLabel.Size = new System.Drawing.Size(108, 20);
            this.typeSearchLabel.TabIndex = 30;
            this.typeSearchLabel.Text = "Released year: ";
            this.typeSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.typeSearchLabel.Visible = false;
            // 
            // groupTypeSearch
            // 
            this.groupTypeSearch.AutoSize = true;
            this.groupTypeSearch.BackColor = System.Drawing.SystemColors.Window;
            this.groupTypeSearch.Controls.Add(this.actorButton);
            this.groupTypeSearch.Controls.Add(this.producerButton);
            this.groupTypeSearch.Controls.Add(this.countryButton);
            this.groupTypeSearch.Controls.Add(this.titleButton);
            this.groupTypeSearch.Controls.Add(this.genreButton);
            this.groupTypeSearch.Controls.Add(this.yearButton);
            this.groupTypeSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupTypeSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTypeSearch.Location = new System.Drawing.Point(14, 205);
            this.groupTypeSearch.Margin = new System.Windows.Forms.Padding(1);
            this.groupTypeSearch.Name = "groupTypeSearch";
            this.groupTypeSearch.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.groupTypeSearch.Size = new System.Drawing.Size(104, 179);
            this.groupTypeSearch.TabIndex = 29;
            this.groupTypeSearch.TabStop = false;
            this.groupTypeSearch.Visible = false;
            // 
            // actorButton
            // 
            this.actorButton.AutoSize = true;
            this.actorButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.actorButton.Location = new System.Drawing.Point(8, 16);
            this.actorButton.Name = "actorButton";
            this.actorButton.Size = new System.Drawing.Size(52, 19);
            this.actorButton.TabIndex = 1;
            this.actorButton.TabStop = true;
            this.actorButton.Text = "actor";
            this.actorButton.UseVisualStyleBackColor = true;
            // 
            // producerButton
            // 
            this.producerButton.AutoSize = true;
            this.producerButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producerButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.producerButton.Location = new System.Drawing.Point(8, 91);
            this.producerButton.Name = "producerButton";
            this.producerButton.Size = new System.Drawing.Size(73, 19);
            this.producerButton.TabIndex = 2;
            this.producerButton.TabStop = true;
            this.producerButton.Text = "producer";
            this.producerButton.UseVisualStyleBackColor = true;
            // 
            // countryButton
            // 
            this.countryButton.AutoSize = true;
            this.countryButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.countryButton.Location = new System.Drawing.Point(8, 41);
            this.countryButton.Name = "countryButton";
            this.countryButton.Size = new System.Drawing.Size(66, 19);
            this.countryButton.TabIndex = 6;
            this.countryButton.TabStop = true;
            this.countryButton.Text = "country";
            this.countryButton.UseVisualStyleBackColor = true;
            // 
            // titleButton
            // 
            this.titleButton.AutoSize = true;
            this.titleButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.titleButton.Location = new System.Drawing.Point(8, 141);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(45, 19);
            this.titleButton.TabIndex = 3;
            this.titleButton.TabStop = true;
            this.titleButton.Text = "title";
            this.titleButton.UseVisualStyleBackColor = true;
            // 
            // genreButton
            // 
            this.genreButton.AutoSize = true;
            this.genreButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.genreButton.Location = new System.Drawing.Point(8, 66);
            this.genreButton.Name = "genreButton";
            this.genreButton.Size = new System.Drawing.Size(55, 19);
            this.genreButton.TabIndex = 5;
            this.genreButton.TabStop = true;
            this.genreButton.Text = "genre";
            this.genreButton.UseVisualStyleBackColor = true;
            // 
            // yearButton
            // 
            this.yearButton.AutoSize = true;
            this.yearButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.yearButton.Location = new System.Drawing.Point(8, 116);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(93, 19);
            this.yearButton.TabIndex = 4;
            this.yearButton.TabStop = true;
            this.yearButton.Text = "released year";
            this.yearButton.UseVisualStyleBackColor = true;
            // 
            // searchTitle
            // 
            this.searchTitle.AutoSize = true;
            this.searchTitle.BackColor = System.Drawing.Color.Transparent;
            this.searchTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.searchTitle.Location = new System.Drawing.Point(221, 26);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(151, 23);
            this.searchTitle.TabIndex = 28;
            this.searchTitle.Text = "Search movies by: ";
            this.searchTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchTitle.Visible = false;
            // 
            // searchImage
            // 
            this.searchImage.BackColor = System.Drawing.Color.Transparent;
            this.searchImage.ImageLocation = "C:\\Users\\Morgane\\Desktop\\Morgane\\INSA\\4INFO\\Object Oriented Programming\\Search_lo" +
    "go.png";
            this.searchImage.InitialImage = null;
            this.searchImage.Location = new System.Drawing.Point(126, 15);
            this.searchImage.Name = "searchImage";
            this.searchImage.Size = new System.Drawing.Size(89, 49);
            this.searchImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.searchImage.TabIndex = 38;
            this.searchImage.TabStop = false;
            this.searchImage.Visible = false;
            this.searchImage.Click += new System.EventHandler(this.searchImage_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.menuLabel.Location = new System.Drawing.Point(276, 338);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(42, 15);
            this.menuLabel.TabIndex = 39;
            this.menuLabel.Text = "Menu";
            this.menuLabel.Click += new System.EventHandler(this.menuLabel_Click);
            // 
            // genreChoice
            // 
            this.genreChoice.BackColor = System.Drawing.Color.White;
            this.genreChoice.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreChoice.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.genreChoice.FormattingEnabled = true;
            this.genreChoice.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animated",
            "Comedy",
            "Crime",
            "Disaster",
            "Documentary",
            "Drama",
            "Fantasy",
            "Horror",
            "Musical",
            "Romance",
            "Science fiction",
            "Spy",
            "Sword and sandal / Peplum",
            "Thriller",
            "War"});
            this.genreChoice.Location = new System.Drawing.Point(14, 96);
            this.genreChoice.Name = "genreChoice";
            this.genreChoice.Size = new System.Drawing.Size(150, 23);
            this.genreChoice.Sorted = true;
            this.genreChoice.TabIndex = 40;
            this.genreChoice.Visible = false;
            this.genreChoice.SelectedIndexChanged += new System.EventHandler(this.genreChoice_SelectedIndexChanged);
            // 
            // yearChoice
            // 
            this.yearChoice.BackColor = System.Drawing.Color.White;
            this.yearChoice.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearChoice.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.yearChoice.FormattingEnabled = true;
            this.yearChoice.Items.AddRange(new object[] {
            "1974",
            "1977",
            "1978",
            "1984",
            "1997",
            "2001",
            "2002",
            "2003",
            "2005",
            "2006",
            "2007",
            "2009",
            "2011",
            "2013",
            "2015",
            "2017",
            "2019"});
            this.yearChoice.Location = new System.Drawing.Point(14, 43);
            this.yearChoice.Name = "yearChoice";
            this.yearChoice.Size = new System.Drawing.Size(60, 23);
            this.yearChoice.Sorted = true;
            this.yearChoice.TabIndex = 41;
            this.yearChoice.SelectedIndexChanged += new System.EventHandler(this.yearChoice_SelectedIndexChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(596, 391);
            this.Controls.Add(this.yearChoice);
            this.Controls.Add(this.genreChoice);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.searchImage);
            this.Controls.Add(this.resultSearch);
            this.Controls.Add(this.checkedListCountry);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.validationTypeSearch);
            this.Controls.Add(this.homePageLabel);
            this.Controls.Add(this.typeSearchLabel);
            this.Controls.Add(this.groupTypeSearch);
            this.Controls.Add(this.searchTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.Text = "Search movies";
            this.groupTypeSearch.ResumeLayout(false);
            this.groupTypeSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultSearch;
        private System.Windows.Forms.CheckedListBox checkedListCountry;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label validationTypeSearch;
        private System.Windows.Forms.Label homePageLabel;
        private System.Windows.Forms.Label typeSearchLabel;
        private System.Windows.Forms.GroupBox groupTypeSearch;
        private System.Windows.Forms.RadioButton actorButton;
        private System.Windows.Forms.RadioButton producerButton;
        private System.Windows.Forms.RadioButton countryButton;
        private System.Windows.Forms.RadioButton titleButton;
        private System.Windows.Forms.RadioButton genreButton;
        private System.Windows.Forms.RadioButton yearButton;
        private System.Windows.Forms.Label searchTitle;
        private System.Windows.Forms.PictureBox searchImage;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.ComboBox genreChoice;
        private System.Windows.Forms.ComboBox yearChoice;
    }
}