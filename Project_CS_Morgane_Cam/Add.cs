using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_CS_Morgane_Cam
{
    public partial class Add : Form
    {
        private int id_movie { get; set; }
        private int id_genre { get; set; }
        private int id_actor { get; set; }
        private int nb_actors { get; set; }
        private int id_producer { get; set; }
        private int nb_producers { get; set; }

        public Add()
        {
            InitializeComponent();
            id_movie = 1;
            id_genre = 0;
            nb_actors = 1;
            nb_producers = 1;
        }

        private void setMoviePage()
        {
            searchTitle.Show();
            searchTitle.Text = "Add a movie";
            searchTitle.Location = new Point(306 - (int)searchTitle.Width / 2, 18);

            nameLabel.Text = "Title:";
            nameLabel.Location = new Point(151, 91);
            nameTextBox.Location = new Point(238, 89);

            yearLabel.Text = "Released year:";
            yearLabel.Location = new Point(151, 125);
            yearTextBox.Location = new Point(238, 123);

            countryLabel.Text = "Country:";
            countryLabel.Location = new Point(151, 159);
            countryTextBox.Location = new Point(238, 157);

            validationMovie.Show();
            validationMovie.Location = new Point(433, 229);

            menuLabel.Show();
            menuLabel.Location = new Point(306 - (int)menuLabel.Width / 2, 338);
        }

        private void validationMovie_Click(object sender, EventArgs e)
        {
            MySqlConnection connection1 = new MySqlConnection("database=mymovies; server=localhost; user id=root; pwd=");
            try { connection1.Open(); }
            catch (MySqlException myExcep) { MessageBox.Show("Not connected: " + myExcep.ToString()); }
            string sql1 = "SELECT `ID_Movie`,`Title_Movie` FROM `movie`";
            MySqlCommand command1 = new MySqlCommand(sql1, connection1);
            MySqlDataReader read1 = command1.ExecuteReader();
            while (read1.Read())
            {
                if (read1.GetValue(1).ToString().Equals(nameTextBox.Text))
                {
                    MessageBox.Show("This movie already exists.");
                    this.Close();
                }
                else
                {
                    id_movie++;
                }
            }

            MySqlConnection connection = new MySqlConnection("database=mymovies; server=localhost; user id=root; pwd=");
            try { connection.Open(); }
            catch (MySqlException myExcep) { MessageBox.Show("Not connected: " + myExcep.ToString()); }
            string sql = "INSERT INTO `movie` (`ID_Movie`, `Title_Movie`, `Year_Movie`, `Country_Movie`) VALUES (" + id_movie + ", '" + nameTextBox.Text + "', '" + yearTextBox.Text + "', '" + countryTextBox.Text + "')";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader read = command.ExecuteReader();

            searchTitle.Text = "Add a genre to the movie";
            searchTitle.Location = new Point(306 - (int)searchTitle.Width / 2, 18);

            nameLabel.Text = "Genre:";
            genreChoice.Show();
            genreChoice.Location = new Point(210, 89);

            nameTextBox.Hide();
            yearLabel.Hide();
            yearTextBox.Hide();
            countryLabel.Hide();
            countryTextBox.Hide();

            validationMovie.Hide();
            validationGenre.Show();
            validationGenre.Location = new Point(433, 229);
        }

        private void validationGenre_Click(object sender, EventArgs e)
        {
            MySqlConnection connection1 = new MySqlConnection("database=mymovies; server=localhost; user id=root; pwd=");
            try { connection1.Open(); }
            catch (MySqlException myExcep) { MessageBox.Show("Not connected: " + myExcep.ToString()); }
            string sql1 = "SELECT * FROM `genre`";
            MySqlCommand command1 = new MySqlCommand(sql1, connection1);
            MySqlDataReader read1 = command1.ExecuteReader();
            while (read1.Read())
            {
                if (read1.GetValue(1).Equals(genreChoice.SelectedText))
                {
                    id_genre = int.Parse(read1.GetValue(0).ToString());
                }
            }
            read1.Close();

            while(id_genre == 0) { }

            MySqlConnection connection2 = new MySqlConnection("database=mymovies; server=localhost; user id=root; pwd=");
            try { connection2.Open(); }
            catch (MySqlException myExcep) { MessageBox.Show("Not connected: " + myExcep.ToString()); }
            string sql2 = "INSERT INTO `belong` (`ID_Genre`, `ID_Movie`) VALUES (" + id_genre + ", '" + id_movie + "')";
            MySqlCommand command2 = new MySqlCommand(sql2, connection2);
            MySqlDataReader read2 = command2.ExecuteReader();
            read2.Close();

            searchTitle.Text = "Add an actor who plays in this movie";
            searchTitle.Location = new Point(306 - (int)searchTitle.Width / 2, 18);

            genreChoice.Hide();

            nameLabel.Text = "Name:";
            nameTextBox.Show();
            nameTextBox.Clear();

            yearLabel.Show();
            yearLabel.Text = "Birth year: ";
            yearTextBox.Show();
            yearTextBox.Clear();

            countryLabel.Show();
            countryTextBox.Show();
            countryTextBox.Clear();

            fourthInfo.Show();
            fourthInfo.Location = new Point(151, 193);
            fourthInfoTextBox.Show();
            fourthInfoTextBox.Location = new Point(238, 191);

            newActorLabel.Show();
            newActorLabel.Location = new Point(280, 229);

            validationGenre.Hide();
            validationActor.Show();
            validationActor.Location = new Point(433, 229);
        }

        private void newActorLabel_Click(object sender, EventArgs e)
        {
            addActor();

            nameTextBox.Clear();
            yearTextBox.Clear();
            countryTextBox.Clear();
            fourthInfoTextBox.Clear();
        }

        private void validationActor_Click(object sender, EventArgs e)
        {
            addActor();

            searchTitle.Text = "Add an producer who produced this movie";
            searchTitle.Location = new Point(306 - (int)searchTitle.Width / 2, 18);

            nameTextBox.Clear();
            yearTextBox.Clear();
            countryTextBox.Clear();
            fourthInfoTextBox.Clear();

            fourthInfo.Text = "Company:";

            newActorLabel.Hide();
            newProducerLabel.Show();
            newProducerLabel.Location = new Point(280, 229);

            validationActor.Hide();
            validationProducer.Show();
            validationProducer.Location = new Point(433, 229);
        }

        private void addActor()
        {
            id_actor = 0;

            MySqlConnection connection1 = new MySqlConnection("database=mymovies; server=localhost; user id=root; pwd=");
            try { connection1.Open(); }
            catch (MySqlException myExcep) { MessageBox.Show("Not connected: " + myExcep.ToString()); }
            string sql1 = "SELECT ID_Actor,Name_Actor FROM `actor`";
            MySqlCommand command1 = new MySqlCommand(sql1, connection1);
            MySqlDataReader read1 = command1.ExecuteReader();
            while (read1.Read())
            {
                if (read1.GetValue(1).Equals(nameTextBox.Text))
                {
                    id_actor = int.Parse(read1.GetValue(0).ToString());
                }
                nb_actors++;
            }
            read1.Close();

            if (id_actor == 0)
            {
                id_actor = nb_actors;
                MySqlConnection connection2 = new MySqlConnection("database=mymovies; server=localhost; user id=root; pwd=");
                try { connection2.Open(); }
                catch (MySqlException myExcep) { MessageBox.Show("Not connected: " + myExcep.ToString()); }
                string sql2 = "INSERT INTO `actor` (`ID_Actor`, `Name_Actor`, `Age_Actor`, `Nationality_Actor`, `Characters_Actor`) " +
                    "VALUES (" + id_actor + ", '" + nameTextBox.Text + "', '" + yearTextBox.Text + "', '" + countryTextBox.Text + "', '" + fourthInfoTextBox.Text + "')";
                MySqlCommand command2 = new MySqlCommand(sql2, connection2);
                MySqlDataReader read2 = command2.ExecuteReader();
                read2.Close();
            }

            MySqlConnection connection3 = new MySqlConnection("database=mymovies; server=localhost; user id=root; pwd=");
            try { connection3.Open(); }
            catch (MySqlException myExcep) { MessageBox.Show("Not connected: " + myExcep.ToString()); }
            string sql3 = "INSERT INTO `play` (`ID_Actor`, `ID_Movie`) VALUES ('" + id_actor + "', '" + id_movie + "')";
            MySqlCommand command3 = new MySqlCommand(sql3, connection3);
            MySqlDataReader read3 = command3.ExecuteReader();
            read3.Close();
        }

        private void newProducerLabel_Click(object sender, EventArgs e)
        {
            addProducer();

            nameTextBox.Clear();
            yearTextBox.Clear();
            countryTextBox.Clear();
            fourthInfoTextBox.Clear();
        }

        private void validationProducer_Click(object sender, EventArgs e)
        {
            addProducer();

            searchTitle.Text = "Movie successfully added";
            searchTitle.Location = new Point(171, 142);

            nameLabel.Hide();
            nameTextBox.Hide();
            yearLabel.Hide();
            yearTextBox.Hide();
            countryLabel.Hide();
            countryTextBox.Hide();
            fourthInfo.Hide();
            fourthInfoTextBox.Hide();
            newProducerLabel.Hide();
            validationProducer.Hide();
        }

        private void addProducer()
        {
            id_producer = 0;

            MySqlConnection connection1 = new MySqlConnection("database=mymovies; server=localhost; user id=root; pwd=");
            try { connection1.Open(); }
            catch (MySqlException myExcep) { MessageBox.Show("Not connected: " + myExcep.ToString()); }
            string sql1 = "SELECT ID_Producer,Name_Producer FROM `producer`";
            MySqlCommand command1 = new MySqlCommand(sql1, connection1);
            MySqlDataReader read1 = command1.ExecuteReader();
            while (read1.Read())
            {
                if (read1.GetValue(1).Equals(nameTextBox.Text))
                {
                    id_producer = int.Parse(read1.GetValue(0).ToString());
                }
                nb_producers++;
            }
            read1.Close();

            if (id_producer == 0)
            {
                id_producer = nb_producers;
                MySqlConnection connection2 = new MySqlConnection("database=mymovies; server=localhost; user id=root; pwd=");
                try { connection2.Open(); }
                catch (MySqlException myExcep) { MessageBox.Show("Not connected: " + myExcep.ToString()); }
                string sql2 = "INSERT INTO `producer` (`ID_Producer`, `Name_Producer`, `Age_Producer`, `Nationality_Producer`, `Company_Producer`) " +
                    "VALUES (" + id_producer + ", '" + nameTextBox.Text + "', '" + yearTextBox.Text + "', '" + countryTextBox.Text + "', '" + fourthInfoTextBox.Text + "')";
                MySqlCommand command2 = new MySqlCommand(sql2, connection2);
                MySqlDataReader read2 = command2.ExecuteReader();
                read2.Close();
            }

            MySqlConnection connection3 = new MySqlConnection("database=mymovies; server=localhost; user id=root; pwd=");
            try { connection3.Open(); }
            catch (MySqlException myExcep) { MessageBox.Show("Not connected: " + myExcep.ToString()); }
            string sql3 = "INSERT INTO `produce` (`ID_Producer`, `ID_Movie`) VALUES ('" + id_producer + "', '" + id_movie + "')";
            MySqlCommand command3 = new MySqlCommand(sql3, connection3);
            MySqlDataReader read3 = command3.ExecuteReader();
            read3.Close();
        }

        private void menuLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
