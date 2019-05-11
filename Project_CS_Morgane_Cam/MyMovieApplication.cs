using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_CS_Morgane_Cam
{
    public partial class MyMovieApplication : Form
    {
        public MyMovieApplication()
        {
            InitializeComponent();
            setConnectionPage();
        }

        /* ------------------------------ Initialisation pages ------------------------------ */

        private void setConnectionPage()
        {
            titleHomePage.Show();
            titleHomePage.Text = "Connection";
            titleHomePage.Location = new Point(306 - (int)titleHomePage.Width / 2, 12);

            loginLabel.Show();
            loginLabel.Location = new Point(200, 118);
            login.Show();
            login.Location = new Point(270, 118);
            login.Clear();

            passwordLabel.Show();
            passwordLabel.Location = new Point(200, 148);
            password.Show();
            password.Location = new Point(270, 148);
            password.PasswordChar = '•';
            password.Clear();

            signInLabel.Show();
            signInLabel.Location = new Point(306 - (int)signInLabel.Width / 2, 188);

            searchButton.Hide();
            addButton.Hide();
            signOutLabel.Hide();
        }

        public void setMenuPage()
        {
            loginLabel.Hide();
            login.Hide();
            passwordLabel.Hide();
            password.Hide();
            signInLabel.Hide();

            titleHomePage.Show();
            titleHomePage.Text = "Welcome in your cinema";
            titleHomePage.Location = new Point(306 - (int)titleHomePage.Width / 2, 12);

            searchButton.Show();

            addButton.Show();

            signOutLabel.Show();
            signOutLabel.Location = new Point(306 - (int)signOutLabel.Width / 2, 338);
        }

        /* ------------- Call new pages when we choose the action we want to do ------------- */

        private void connectionLabel_Click(object sender, EventArgs e)
        {
            if (login.Text.Equals("user") && password.Text.Equals("123456"))
                setMenuPage();
            else
            {
                MessageBox.Show("Incorrect login and/or password.");
                login.Clear();
                password.Clear();
            }
        }

        private void deconnectionLabel_Click(object sender, EventArgs e)
        {
            setConnectionPage();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }
    }
}
