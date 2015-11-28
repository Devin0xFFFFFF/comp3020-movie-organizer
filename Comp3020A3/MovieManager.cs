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

                    /*

                    Console.WriteLine("1" + reader.Name + " : " + reader.Value);
                    reader.Read();
                    Console.WriteLine("2" + reader.Name + " : " + reader.Value);
                    reader.Read();
                    Console.WriteLine("3" + reader.Name + " : " + reader.Value);
                    reader.Read();
                    Console.WriteLine("4" + reader.Name + " : " + reader.Value);
                    reader.Read();
                    Console.WriteLine("5" + reader.Name + " : " + reader.Value);
                    reader.Read();
                    Console.WriteLine("6" + reader.Name + " : " + reader.Value);
                    reader.Read();
                    Console.WriteLine("7" + reader.Name + " : " + reader.Value);
                    reader.Read();
                    Console.WriteLine("8" + reader.Name + " : " + reader.Value);
                    reader.Read();
                    Console.WriteLine("9" + reader.Name + " : " + reader.Value);

                    */

                    reader.Read();
                    reader.Read();

                    while (reader.NodeType != XmlNodeType.EndElement && reader.Name != "movie")
                    {
                        //Console.WriteLine(reader.Name + " : " + reader.Value);
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
                    movies.Add(new Movie() { title = t, year = y, length = len, certification = cert, director = dir, rating = r, genres = lgenres, actors = lactors });
                    cert = "";
                }
            }

            reader.Close();

            DataAccess.writeMovies(movies);
        }
    }
}
