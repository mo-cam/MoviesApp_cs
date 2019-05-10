using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project_CS_Morgane_Cam
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            setHomePage();
        }

        /* ------------------------------ Initialisation pages ------------------------------ */

        private void setHomePage()
        {
            searchTitle.Show();
            searchTitle.Text = "Search initialisation";
            searchTitle.Location = new Point(306 - (int)searchTitle.Width / 2, 18);

            groupTypeSearch.Show();
            groupTypeSearch.Location = new Point(306 - (int)groupTypeSearch.Width / 2, 75);

            validationTypeSearch.Show();
            validationTypeSearch.Location = new Point(306 - (int)validationTypeSearch.Width / 2, 292);

            menuLabel.Show();
            menuLabel.Location = new Point(306 - (int)menuLabel.Width / 2, 338);

            /* Set the visibility of all the widgets from the other pages to false */
            homePageLabel.Hide();
            typeSearchLabel.Hide();
            textBox.Hide();
            searchImage.Hide();
            resultSearch.Hide();
            checkedListCountry.Hide();
            genreChoice.Hide();
            yearChoice.Hide();
            resultSearch.Hide();
        }

        private void setActorPage()
        {
            searchTitle.Text = "Search a movie by an actor's name";
            searchTitle.Location = new Point(306 - (int)searchTitle.Size.Width / 2, 18);
            groupTypeSearch.Hide();
            validationTypeSearch.Hide();
            menuLabel.Hide();

            homePageLabel.Show();

            typeSearchLabel.Show();
            typeSearchLabel.Text = "Cast: ";
            typeSearchLabel.Location = new Point(128, 80);

            textBox.Show();
            textBox.Location = new Point(170, 80);
            textBox.Size = new Size(new Point(205, 20));
            textBox.Clear();

            searchImage.Show();
            searchImage.Location = new Point(382, 68);
        }

        private void setCountryPage()
        {
            searchTitle.Text = "Search a movie by country";
            searchTitle.Location = new Point(306 - (int)searchTitle.Size.Width / 2, 18);
            groupTypeSearch.Hide();
            validationTypeSearch.Hide();
            menuLabel.Hide();

            homePageLabel.Show();

            typeSearchLabel.Show();
            typeSearchLabel.Text = "Country: ";
            typeSearchLabel.Location = new Point(128, 74);

            checkedListCountry.Show();
            checkedListCountry.Location = new Point(200, 68);
            checkedListCountry.ClearSelected();
        }

        private void setGenrePage()
        {
            searchTitle.Text = "Search a movie by its genre";
            searchTitle.Location = new Point(306 - (int)searchTitle.Size.Width / 2, 18);
            groupTypeSearch.Hide();
            validationTypeSearch.Hide();
            menuLabel.Hide();

            homePageLabel.Show();

            typeSearchLabel.Show();
            typeSearchLabel.Text = "Genre: ";
            typeSearchLabel.Location = new Point(128, 74);

            genreChoice.Show();
            genreChoice.Location = new Point(190, 74);
        }

        private void setProducerPage()
        {
            searchTitle.Text = "Search a movie by a director/producer/writer's name";
            searchTitle.Location = new Point(306 - (int)searchTitle.Size.Width / 2, 18);
            groupTypeSearch.Hide();
            validationTypeSearch.Hide();
            menuLabel.Hide();

            homePageLabel.Show();

            typeSearchLabel.Show();
            typeSearchLabel.Text = "Produced by: ";
            typeSearchLabel.Location = new Point(128, 80);

            textBox.Show();
            textBox.Location = new Point(225, 80);
            textBox.Size = new Size(new Point(150, 20));
            textBox.Clear();

            searchImage.Show();
            searchImage.Location = new Point(382, 68);
        }

        private void setYearPage()
        {
            searchTitle.Text = "Search a movie by its released year";
            searchTitle.Location = new Point(306 - (int)searchTitle.Size.Width / 2, 18);
            groupTypeSearch.Hide();
            validationTypeSearch.Hide();
            menuLabel.Hide();

            homePageLabel.Show();

            typeSearchLabel.Show();
            typeSearchLabel.Text = "Released year: ";
            typeSearchLabel.Location = new Point(128, 74);

            yearChoice.Show();
            yearChoice.Location = new Point(240, 74);
        }

        private void setTitlePage()
        {
            searchTitle.Text = "Search a movie by its title";
            searchTitle.Location = new Point(306 - (int)searchTitle.Size.Width / 2, 18);
            groupTypeSearch.Hide();
            validationTypeSearch.Hide();
            menuLabel.Hide();

            homePageLabel.Show();

            typeSearchLabel.Show();
            typeSearchLabel.Text = "Title: ";
            typeSearchLabel.Location = new Point(128, 80);

            textBox.Show();
            textBox.Location = new Point(170, 80);
            textBox.Size = new Size(new Point(205, 20));
            textBox.Clear();

            searchImage.Show();
            searchImage.Location = new Point(382, 68);
        }

        /* --------------- Call new pages when the type of search is selected --------------- */

        private void validationTypeSearch_Click(object sender, EventArgs e)
        {
            if (actorButton.Checked) setActorPage();
            if (countryButton.Checked) setCountryPage();
            if (genreButton.Checked) setGenrePage();
            if (producerButton.Checked) setProducerPage();
            if (yearButton.Checked) setYearPage();
            if (titleButton.Checked) setTitlePage();
        }

        private void homePageLabel_Click(object sender, EventArgs e)
        {
            setHomePage();
        }

        private void menuLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* --------------------------------- Do the search --------------------------------- */

        private KeyValuePair<string[,], int> doSearch()
        {
            MySqlConnection connection = new MySqlConnection("database=mymovies; server=localhost; user id=root; pwd=");

            try { connection.Open(); }
            catch (MySqlException myExcep) { MessageBox.Show("Not connected: " + myExcep.ToString()); }

            string[,] movies = new string[300, 6];
            int moviesSize = 0;
            bool added = false;

            string sql = "SELECT movie.Title_Movie, movie.Year_Movie, movie.Country_Movie, actor.Name_Actor, producer.Name_Producer, genre.Name_Genre " +
                    "FROM movie, actor, play, producer, produce, genre, belong " +
                    "WHERE play.ID_Movie = movie.ID_Movie AND play.ID_Actor = actor.ID_Actor AND produce.ID_Movie = movie.ID_Movie AND produce.ID_Producer = producer.ID_Producer AND belong.ID_Movie = movie.ID_Movie AND belong.ID_Genre = genre.ID_Genre";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader read = command.ExecuteReader();

            resultSearch.Show();
            resultSearch.Location = new Point(22, 130);
            resultSearch.Height = 200;
            resultSearch.Clear();

            while (read.Read())
            {
                if (moviesSize == 0)
                {
                    movies[0, 0] = read.GetValue(0).ToString();
                    movies[0, 1] = read.GetValue(1).ToString();
                    movies[0, 2] = read.GetValue(2).ToString();
                    movies[0, 3] = read.GetValue(3).ToString();
                    movies[0, 4] = read.GetValue(4).ToString();
                    movies[0, 5] = read.GetValue(5).ToString();
                    moviesSize++;
                }
                else
                {
                    added = false;
                    for (int index = 0; index < moviesSize; index++)
                    {
                        if (movies[index, 0].Equals(read.GetValue(0).ToString()))
                        {
                            if (movies[index, 4].Contains(read.GetValue(4).ToString()))
                            {
                                movies[index, 3] += " . " + read.GetValue(3).ToString();
                                added = true;
                            }
                        }
                    }
                    if (added == false)
                    {
                        movies[moviesSize, 0] = read.GetValue(0).ToString();
                        movies[moviesSize, 1] = read.GetValue(1).ToString();
                        movies[moviesSize, 2] = read.GetValue(2).ToString();
                        movies[moviesSize, 3] = read.GetValue(3).ToString();
                        movies[moviesSize, 4] = read.GetValue(4).ToString();
                        movies[moviesSize, 5] = read.GetValue(5).ToString();
                        moviesSize++;
                    }
                }
            }

            return new KeyValuePair<string[,], int>(movies, moviesSize);
        }

        private void searchImage_Click(object sender, EventArgs e)
        {
            if (actorButton.Checked)
            {
                string[,] movies = doSearch().Key;
                int moviesSize = doSearch().Value;

                for (int i = 0; i < moviesSize; i++)
                {
                    if (movies[i, 3].ToLower().Contains(textBox.Text.ToLower()))
                    {
                        string title = movies[i, 0];
                        resultSearch.AppendText("Title: \t\t" + movies[i, 0] + Environment.NewLine);
                        resultSearch.AppendText("Released year: \t" + movies[i, 1] + Environment.NewLine);
                        resultSearch.AppendText("Country: \t\t" + movies[i, 2] + Environment.NewLine);
                        resultSearch.AppendText("Genre: \t\t" + movies[i, 5] + Environment.NewLine);
                        resultSearch.AppendText("Main actors: \t" + movies[i, 3] + Environment.NewLine);
                        resultSearch.AppendText("Main producers: \t" + movies[i, 4]);
                        for (int j = i + 1; j < moviesSize; j++)
                        {
                            if (movies[j, 0].Equals(title))
                            {
                                resultSearch.AppendText(" . " + movies[j, 4]);
                                for (int line = j; line < moviesSize - 1; line++)
                                {
                                    movies[line, 0] = movies[line + 1, 0];
                                    movies[line, 1] = movies[line + 1, 1];
                                    movies[line, 2] = movies[line + 1, 2];
                                    movies[line, 3] = movies[line + 1, 3];
                                    movies[line, 4] = movies[line + 1, 4];
                                    movies[line, 5] = movies[line + 1, 5];
                                }
                                movies[moviesSize - 1, 0] = null;
                                movies[moviesSize - 1, 1] = null;
                                movies[moviesSize - 1, 2] = null;
                                movies[moviesSize - 1, 3] = null;
                                movies[moviesSize - 1, 4] = null;
                                movies[moviesSize - 1, 5] = null;
                                moviesSize--;
                                j--;
                            }
                        }
                        resultSearch.AppendText(Environment.NewLine + Environment.NewLine);
                    }
                }

                if (resultSearch.Text == "")
                    resultSearch.Text = "Sorry, we don't have any movie in which this actor plays.";
            }

            /*
             * Can not use doSearch because we have to sort first by producer and then, when we want to display the result, by actor
             */
            if (producerButton.Checked)
            {
                MySqlConnection connection = new MySqlConnection("database=mymovies; server=localhost; user id=root; pwd=");

                try { connection.Open(); }
                catch (MySqlException myExcep) { MessageBox.Show("Not connected: " + myExcep.ToString()); }

                string[,] movies = new string[300, 6];
                int moviesSize = 0;
                bool added = false;

                string sql = "SELECT movie.Title_Movie, movie.Year_Movie, movie.Country_Movie, actor.Name_Actor, producer.Name_Producer, genre.Name_Genre " +
                    "FROM movie, actor, play, producer, produce, genre, belong " +
                    "WHERE play.ID_Movie = movie.ID_Movie AND play.ID_Actor = actor.ID_Actor AND produce.ID_Movie = movie.ID_Movie AND produce.ID_Producer = producer.ID_Producer AND belong.ID_Movie = movie.ID_Movie AND belong.ID_Genre = genre.ID_Genre";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader read = command.ExecuteReader();

                resultSearch.Show();
                resultSearch.Location = new Point(22, 130);
                resultSearch.Height = 200;
                resultSearch.Clear();

                while (read.Read())
                {
                    if (moviesSize == 0)
                    {
                        movies[0, 0] = read.GetValue(0).ToString();
                        movies[0, 1] = read.GetValue(1).ToString();
                        movies[0, 2] = read.GetValue(2).ToString();
                        movies[0, 3] = read.GetValue(3).ToString();
                        movies[0, 4] = read.GetValue(4).ToString();
                        movies[0, 5] = read.GetValue(5).ToString();
                        moviesSize++;
                    }
                    else
                    {
                        added = false;
                        for (int index = 0; index < moviesSize; index++)
                        {
                            if (movies[index, 0].Equals(read.GetValue(0).ToString()))
                            {
                                if (movies[index, 3].Contains(read.GetValue(3).ToString()))
                                {
                                    movies[index, 4] += " . " + read.GetValue(4).ToString();
                                    added = true;
                                }
                            }
                        }
                        if (added == false)
                        {
                            movies[moviesSize, 0] = read.GetValue(0).ToString();
                            movies[moviesSize, 1] = read.GetValue(1).ToString();
                            movies[moviesSize, 2] = read.GetValue(2).ToString();
                            movies[moviesSize, 3] = read.GetValue(3).ToString();
                            movies[moviesSize, 4] = read.GetValue(4).ToString();
                            movies[moviesSize, 5] = read.GetValue(5).ToString();
                            moviesSize++;
                        }
                    }
                }

                for (int i = 0; i < moviesSize; i++)
                {
                    if (movies[i, 4].ToLower().Contains(textBox.Text.ToLower()))
                    {
                        string title = movies[i, 0];
                        resultSearch.AppendText("Title: \t\t" + movies[i, 0] + Environment.NewLine);
                        resultSearch.AppendText("Released year: \t" + movies[i, 1] + Environment.NewLine);
                        resultSearch.AppendText("Country: \t\t" + movies[i, 2] + Environment.NewLine);
                        resultSearch.AppendText("Genre: \t\t" + movies[i, 5] + Environment.NewLine);
                        resultSearch.AppendText("Main actors: \t" + movies[i, 3]);
                        for (int j = i + 1; j < moviesSize; j++)
                        {
                            if (movies[j, 0].Equals(title))
                            {
                                resultSearch.AppendText(" . " + movies[j, 3]);
                                for (int line = j; line < moviesSize - 1; line++)
                                {
                                    movies[line, 0] = movies[line + 1, 0];
                                    movies[line, 1] = movies[line + 1, 1];
                                    movies[line, 2] = movies[line + 1, 2];
                                    movies[line, 3] = movies[line + 1, 3];
                                    movies[line, 4] = movies[line + 1, 4];
                                    movies[line, 5] = movies[line + 1, 5];
                                }
                                movies[moviesSize - 1, 0] = null;
                                movies[moviesSize - 1, 1] = null;
                                movies[moviesSize - 1, 2] = null;
                                movies[moviesSize - 1, 3] = null;
                                movies[moviesSize - 1, 4] = null;
                                movies[moviesSize - 1, 5] = null;
                                moviesSize--;
                                j--;
                            }
                        }
                        resultSearch.AppendText(Environment.NewLine + "Main producers: \t" + movies[i, 4]);
                        resultSearch.AppendText(Environment.NewLine + Environment.NewLine);
                    }
                }

                if (resultSearch.Text == "")
                    resultSearch.Text = "Sorry, we don't have any movie produced by this producer.";
            }

            if (titleButton.Checked)
            {
                string[,] movies = doSearch().Key;
                int moviesSize = doSearch().Value;

                for (int i = 0; i < moviesSize; i++)
                {
                    if (movies[i, 0].ToLower().Contains(textBox.Text.ToLower()))
                    {
                        string title = movies[i, 0];
                        resultSearch.AppendText("Title: \t\t" + movies[i, 0] + Environment.NewLine);
                        resultSearch.AppendText("Released year: \t" + movies[i, 1] + Environment.NewLine);
                        resultSearch.AppendText("Country: \t\t" + movies[i, 2] + Environment.NewLine);
                        resultSearch.AppendText("Genre: \t\t" + movies[i, 5] + Environment.NewLine);
                        resultSearch.AppendText("Main actors: \t" + movies[i, 3] + Environment.NewLine);
                        resultSearch.AppendText("Main producers: \t" + movies[i, 4]);
                        for (int j = i + 1; j < moviesSize; j++)
                        {
                            if (movies[j, 0].Equals(title))
                            {
                                resultSearch.AppendText(" . " + movies[j, 4]);
                                for (int line = j; line < moviesSize - 1; line++)
                                {
                                    movies[line, 0] = movies[line + 1, 0];
                                    movies[line, 1] = movies[line + 1, 1];
                                    movies[line, 2] = movies[line + 1, 2];
                                    movies[line, 3] = movies[line + 1, 3];
                                    movies[line, 4] = movies[line + 1, 4];
                                    movies[line, 5] = movies[line + 1, 5];
                                }
                                movies[moviesSize - 1, 0] = null;
                                movies[moviesSize - 1, 1] = null;
                                movies[moviesSize - 1, 2] = null;
                                movies[moviesSize - 1, 3] = null;
                                movies[moviesSize - 1, 4] = null;
                                movies[moviesSize - 1, 5] = null;
                                moviesSize--;
                                j--;
                            }
                        }
                        resultSearch.AppendText(Environment.NewLine + Environment.NewLine);
                    }
                }

                if (resultSearch.Text == "")
                    resultSearch.Text = "Sorry, we don't have any movie corresponding to this title.";
            }
        }

        /**
         * Select several countries if you want movies from different countries
         */
        private void checkedListCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[,] movies = doSearch().Key;
            int moviesSize = doSearch().Value;

            for (int i = 0; i < moviesSize; i++)
            {
                if (checkedListCountry.CheckedItems.Contains(movies[i, 2].ToString()))
                {
                    string title = movies[i, 0];
                    resultSearch.AppendText("Title: \t\t" + movies[i, 0] + Environment.NewLine);
                    resultSearch.AppendText("Released year: \t" + movies[i, 1] + Environment.NewLine);
                    resultSearch.AppendText("Country: \t\t" + movies[i, 2] + Environment.NewLine);
                    resultSearch.AppendText("Genre: \t\t" + movies[i, 5] + Environment.NewLine);
                    resultSearch.AppendText("Main actors: \t" + movies[i, 3] + Environment.NewLine);
                    resultSearch.AppendText("Main producers: \t" + movies[i, 4]);
                    for (int j = i + 1; j < moviesSize; j++)
                    {
                        if (movies[j, 0].Equals(title))
                        {
                            resultSearch.AppendText(" . " + movies[j, 4]);
                            for (int line = j; line < moviesSize - 1; line++)
                            {
                                movies[line, 0] = movies[line + 1, 0];
                                movies[line, 1] = movies[line + 1, 1];
                                movies[line, 2] = movies[line + 1, 2];
                                movies[line, 3] = movies[line + 1, 3];
                                movies[line, 4] = movies[line + 1, 4];
                                movies[line, 5] = movies[line + 1, 5];
                            }
                            movies[moviesSize - 1, 0] = null;
                            movies[moviesSize - 1, 1] = null;
                            movies[moviesSize - 1, 2] = null;
                            movies[moviesSize - 1, 3] = null;
                            movies[moviesSize - 1, 4] = null;
                            movies[moviesSize - 1, 5] = null;
                            moviesSize--;
                            j--;
                        }
                    }
                    resultSearch.AppendText(Environment.NewLine + Environment.NewLine);
                }
            }

            if (resultSearch.Text == "")
                resultSearch.Text = "Sorry, we don't have any movie from this country.";
        }

        /**
         * Select several genres if you want movies from different genres 
         */
        private void genreChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[,] movies = doSearch().Key;
            int moviesSize = doSearch().Value;

            for (int i = 0; i < moviesSize; i++)
            {
                if (genreChoice.SelectedItem.Equals(movies[i, 5].ToString()))
                {
                    string title = movies[i, 0];
                    resultSearch.AppendText("Title: \t\t" + movies[i, 0] + Environment.NewLine);
                    resultSearch.AppendText("Released year: \t" + movies[i, 1] + Environment.NewLine);
                    resultSearch.AppendText("Country: \t\t" + movies[i, 2] + Environment.NewLine);
                    resultSearch.AppendText("Genre: \t\t" + movies[i, 5] + Environment.NewLine);
                    resultSearch.AppendText("Main actors: \t" + movies[i, 3] + Environment.NewLine);
                    resultSearch.AppendText("Main producers: \t" + movies[i, 4]);
                    for (int j = i + 1; j < moviesSize; j++)
                    {
                        if (movies[j, 0].Equals(title))
                        {
                            resultSearch.AppendText(" . " + movies[j, 4]);
                            for (int line = j; line < moviesSize - 1; line++)
                            {
                                movies[line, 0] = movies[line + 1, 0];
                                movies[line, 1] = movies[line + 1, 1];
                                movies[line, 2] = movies[line + 1, 2];
                                movies[line, 3] = movies[line + 1, 3];
                                movies[line, 4] = movies[line + 1, 4];
                                movies[line, 5] = movies[line + 1, 5];
                            }
                            movies[moviesSize - 1, 0] = null;
                            movies[moviesSize - 1, 1] = null;
                            movies[moviesSize - 1, 2] = null;
                            movies[moviesSize - 1, 3] = null;
                            movies[moviesSize - 1, 4] = null;
                            movies[moviesSize - 1, 5] = null;
                            moviesSize--;
                            j--;
                        }
                    }
                    resultSearch.AppendText(Environment.NewLine + Environment.NewLine);
                }
            }

            if (resultSearch.Text == "")
                resultSearch.Text = "Sorry, we don't have any movie in this category.";
        }

        /**
         * You can only chose one year per one year
         */
        private void yearChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[,] movies = doSearch().Key;
            int moviesSize = doSearch().Value;

            for (int i = 0; i < moviesSize; i++)
            {
                if (yearChoice.SelectedItem.Equals(movies[i, 1].ToString()))
                {
                    string title = movies[i, 0];
                    resultSearch.AppendText("Title: \t\t" + movies[i, 0] + Environment.NewLine);
                    resultSearch.AppendText("Released year: \t" + movies[i, 1] + Environment.NewLine);
                    resultSearch.AppendText("Country: \t\t" + movies[i, 2] + Environment.NewLine);
                    resultSearch.AppendText("Genre: \t\t" + movies[i, 5] + Environment.NewLine);
                    resultSearch.AppendText("Main actors: \t" + movies[i, 3] + Environment.NewLine);
                    resultSearch.AppendText("Main producers: \t" + movies[i, 4]);
                    for (int j = i + 1; j < moviesSize; j++)
                    {
                        if (movies[j, 0].Equals(title))
                        {
                            resultSearch.AppendText(" . " + movies[j, 4]);
                            for (int line = j; line < moviesSize - 1; line++)
                            {
                                movies[line, 0] = movies[line + 1, 0];
                                movies[line, 1] = movies[line + 1, 1];
                                movies[line, 2] = movies[line + 1, 2];
                                movies[line, 3] = movies[line + 1, 3];
                                movies[line, 4] = movies[line + 1, 4];
                                movies[line, 5] = movies[line + 1, 5];
                            }
                            movies[moviesSize - 1, 0] = null;
                            movies[moviesSize - 1, 1] = null;
                            movies[moviesSize - 1, 2] = null;
                            movies[moviesSize - 1, 3] = null;
                            movies[moviesSize - 1, 4] = null;
                            movies[moviesSize - 1, 5] = null;
                            moviesSize--;
                            j--;
                        }
                    }
                    resultSearch.AppendText(Environment.NewLine + Environment.NewLine);
                }
            }

            if (resultSearch.Text == "")
                resultSearch.Text = "Sorry, we don't have any movie released in this year.";
        }
       
    }
}
