namespace Project_CS_Morgane_Cam
{
    partial class MyMovieApplication
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMovieApplication));
            this.titleHomePage = new System.Windows.Forms.Label();
            this.mymovies = new System.Windows.Forms.OpenFileDialog();
            this.login = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.deconnectionLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleHomePage
            // 
            this.titleHomePage.AutoSize = true;
            this.titleHomePage.BackColor = System.Drawing.SystemColors.WindowText;
            this.titleHomePage.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleHomePage.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.titleHomePage.Location = new System.Drawing.Point(159, 18);
            this.titleHomePage.Name = "titleHomePage";
            this.titleHomePage.Size = new System.Drawing.Size(292, 39);
            this.titleHomePage.TabIndex = 9;
            this.titleHomePage.Text = "Welcome in your cinema";
            this.titleHomePage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mymovies
            // 
            this.mymovies.FileName = "mymovies";
            this.mymovies.Filter = "Fichiers XLSX (.xlsx) | .xlsx";
            this.mymovies.Title = "Select the file listing the movies:";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(12, 37);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(120, 20);
            this.login.TabIndex = 29;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.White;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.loginLabel.Location = new System.Drawing.Point(12, 18);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(40, 15);
            this.loginLabel.TabIndex = 30;
            this.loginLabel.Text = "Login:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 78);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(120, 20);
            this.password.TabIndex = 31;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.White;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.passwordLabel.Location = new System.Drawing.Point(12, 60);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 15);
            this.passwordLabel.TabIndex = 32;
            this.passwordLabel.Text = "Password:";
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.BackColor = System.Drawing.Color.White;
            this.connectionLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.connectionLabel.Location = new System.Drawing.Point(12, 101);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(52, 15);
            this.connectionLabel.TabIndex = 33;
            this.connectionLabel.Text = "Connect";
            this.connectionLabel.Click += new System.EventHandler(this.connectionLabel_Click);
            // 
            // deconnectionLabel
            // 
            this.deconnectionLabel.AutoSize = true;
            this.deconnectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.deconnectionLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deconnectionLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.deconnectionLabel.Location = new System.Drawing.Point(259, 338);
            this.deconnectionLabel.Name = "deconnectionLabel";
            this.deconnectionLabel.Size = new System.Drawing.Size(93, 15);
            this.deconnectionLabel.TabIndex = 34;
            this.deconnectionLabel.Text = "Deconnection";
            this.deconnectionLabel.Click += new System.EventHandler(this.deconnectionLabel_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Location = new System.Drawing.Point(211, 137);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 47);
            this.searchButton.TabIndex = 35;
            this.searchButton.Text = "Search a movie";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(325, 137);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(74, 47);
            this.addButton.TabIndex = 36;
            this.addButton.Text = "Add a movie";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // MyMovieApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(596, 391);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deconnectionLabel);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.titleHomePage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyMovieApplication";
            this.Text = "My movie explorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleHomePage;
        private System.Windows.Forms.OpenFileDialog mymovies;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label connectionLabel;
        private System.Windows.Forms.Label deconnectionLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addButton;
    }
}

