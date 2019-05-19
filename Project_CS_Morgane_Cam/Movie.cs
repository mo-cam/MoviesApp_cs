using System.Collections.Generic;

namespace Project_CS_Morgane_Cam
{
    public enum FilmGenre
    {
        Action, 
        Adventure, 
        Animated,
        Comedy, 
        Crime,
        Disaster, 
        Documentary, 
        Drama, 
        Fantasy, 
        Horror,
        Musical,
        Romance, 
        Science_fiction,
        Spy,
        Sword_and_sandal,
        Thriller,
        War,
        Western
    };

    public class Movie
    {
        public int id;
        public string title { get; set; }
        public int releaseYear { get; set; }
        public List<Actor> mainActors { get; set; }
        public List<Producer> producers { get; set; }
        public string country { get; set; }
        public List<FilmGenre> genres { get; set; }

        public Movie(string t, int year, List<Actor> a, List<Producer> p, string c, List<FilmGenre> g)
        {
            title = t;
            releaseYear = year;
            foreach (Actor act in a)
                mainActors.Add(act);
            foreach (Producer prod in p)
                producers.Add(prod);
            country = c;
            foreach (FilmGenre genre in g)
                genres.Add(genre);
        }

        public override string ToString()
        {
            string res = title + ": " + releaseYear + " | " + country + " | " ;

            for (int i = 0; i < genres.Count - 1; i++)
                res += genres[i] + ",";
            res += genres[genres.Count - 1] + " | ";

            for (int i = 0; i < producers.Count - 1; i++)
                res += producers[i].name + ",";
            res += producers[producers.Count - 1].name + " | ";

            for (int i = 0; i < mainActors.Count - 1; i++)
                res += mainActors[i].name + ",";
            res += mainActors[mainActors.Count - 1].name;

            return res;
        }

    }
}
