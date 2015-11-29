using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    public class MovieList
    {
        public static int MAX_NAME_LENGTH = 50;

        public long ID { get; set; }
        public string name { get; set; }
        public string user { get; set; }
        public List<string> movies { get; set; }

        public bool contains(string movie)
        {
            return movies.Contains(movie);
        }

        public bool removeMovie(string movie)
        {
            int i = 0;

            while(i < movies.Count && !movies[i].Equals(movie))
            {
                i++;
            }

            if(i < movies.Count)
            {
                movies.RemoveAt(i);
                return true;
            }

            return false;
        }

        public bool valid(List<FormError> errors)
        {
            int errs = errors.Count;

            ID = DataAccess.validateMovieListID(ID);

            if (ID == -1)
            {
                errors.Add(new FormError() { err_code = "IDCONFLICT", err_msg = "Cannot create review at this time." });
            }

            if (name.Length > MAX_NAME_LENGTH)
            {
                errors.Add(new FormError() { err_code = "TITLELEN", err_msg = "List name too long (" + name.Length + "/" + MAX_NAME_LENGTH + ")." });
            }
            else if (name.Length < 1)
            {
                errors.Add(new FormError() { err_code = "TITLELEN", err_msg = "List name too short (" + name.Length + "/" + MAX_NAME_LENGTH + ")." });
            }

            //Unique ID
            List<MovieList> ml = DataAccess.readMovieLists();
            int i = 0;

            while (i < ml.Count && !ID.Equals(ml.ElementAt(i)))
            {
                i++;
            }

            if (i != ml.Count)
            {
                errors.Add(new FormError() { err_code = "NOTUNIQUEID", err_msg = "ID '" + ID + "' is taken." });
            }

            //may add verification for author, movie

            return errs == errors.Count;
        }
    }
}
