using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Comp3020A3
{
    class MovieManager
    {
        public static List<Movie> getMovies(List<Movie> movies, int amt)
        {
            List<Movie> movs = new List<Movie>();
            int i;

            for (i = 0; i <= amt && i < movies.Count; i++)
            {
                movs.Add(movies.ElementAt(i));
            }

            return movs;
        }

        public static List<Movie> getMovies(List<string> titles)
        {
            List<Movie> movies = new List<Movie>();
            
            if(titles.Count > 0)
            {
                List<Movie> movs = DataAccess.readMovies();
                int i, j;

                for (i = 0; i < titles.Count; i++)
                {
                    j = 0;

                    while (j < movs.Count && !movs.ElementAt(j).title.Equals(titles[i]))
                    {
                        j++;
                    }

                    if (j < movs.Count)
                    {
                        movies.Add(movs[j]);
                    }
                }
            }

            return movies;
        }

        public static void sortByYear(List<Movie> movies)
        {
            movies.Sort(delegate (Movie x, Movie y)
            {
                return y.year.CompareTo(x.year);
            });
        }

        public static void sortByTitle(List<Movie> movies)
        {
            movies.Sort(delegate (Movie x, Movie y)
            {
                return x.title.CompareTo(y.title);
            });
        }

        public static void sortByRating(List<Movie> movies)
        {
            movies.Sort(delegate (Movie x, Movie y)
            {
                return y.rating.CompareTo(x.rating);
            });
        }

        public static void sortByLength(List<Movie> movies)
        {
            movies.Sort(delegate (Movie x, Movie y)
            {
                return x.length.CompareTo(y.length);
            });
        }

        public static void sortByGenres(List<Movie> movies)
        {
            movies.Sort(delegate (Movie x, Movie y)
            {
                return x.genreList[0].CompareTo(y.genreList[0]);
            });
        }

        public static void sortByActors(List<Movie> movies)
        {
            movies.Sort(delegate (Movie x, Movie y)
            {
                return x.actorList[0].CompareTo(y.actorList[0]);
            });
        }

        public static void sortByDirector(List<Movie> movies)
        {
            movies.Sort(delegate (Movie x, Movie y)
            {
                return x.director.CompareTo(y.director);
            });
        }

        public static void sortByCertification(List<Movie> movies)
        {
            movies.Sort(delegate (Movie x, Movie y)
            {
                return y.certification.CompareTo(x.certification);
            });
        }

        public static Movie getMovie(string title)
        {
            Movie movie = null;
            List < Movie > movies = DataAccess.readMovies();
            int i = 0;

            while(i < movies.Count && !movies.ElementAt(i).title.Equals(title))
            {
                i++;
            }

            if(i < movies.Count)
            {
                movie = movies.ElementAt(i);
            }

            return movie;
        }

        public static void convertXMLFormats(string xml_in_path)
        {
            List<Movie> movies = new List<Movie>();

            XmlTextReader reader = new XmlTextReader(xml_in_path);

            string t = "";
            int y = 0, len = 0;
            string cert = "";
            string dir = "";
            int r = 0;
            List<string> lgenres, lactors;

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "movie")
                {
                    lgenres = new List<string>();
                    lactors = new List<string>();

                    reader.Read();
                    reader.Read();

                    while (reader.NodeType != XmlNodeType.EndElement && reader.Name != "movie")
                    {
                        if (reader.Name == "title")
                        {
                            reader.Read();
                            t = reader.Value;
                        }
                        else if (reader.Name == "year")
                        {
                            reader.Read();
                            y = int.Parse(reader.Value);
                        }
                        else if (reader.Name == "length")
                        {
                            reader.Read();
                            string[] val = reader.Value.Split(' ');
                            len = int.Parse(val[0]);
                        }
                        else if (reader.Name == "certification")
                        {
                            reader.Read();
                            cert = reader.Value;
                        }
                        else if (reader.Name == "director")
                        {
                            reader.Read();
                            dir = reader.Value;
                        }
                        else if (reader.Name == "rating")
                        {
                            reader.Read();
                            r = int.Parse(reader.Value);
                        }
                        else if (reader.Name == "genre")
                        {
                            reader.Read();
                            lgenres.Add(reader.Value);
                        }
                        else if (reader.Name == "actor")
                        {
                            reader.Read();
                            lactors.Add(reader.Value);
                        }

                        reader.Read();
                        reader.Read();
                        reader.Read();
                        
                    }
                    movies.Add(new Movie() { title = t, year = y, length = len, certification = cert, director = dir, rating = r, genreList = lgenres, actorList = lactors });
                    movies[movies.Count - 1].initLists();
                    cert = "";
                }
            }

            reader.Close();

            DataAccess.writeMovies(movies);
        }
    }
}
