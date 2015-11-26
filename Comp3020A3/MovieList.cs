using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    public class MovieList
    {
        public long ID { get; set; }
        public string name { get; set; }
        public string user { get; set; }
        public List<string> movies { get; set; }

        public bool contains(string movie)
        {
            return movies.Contains(movie);
        }

        public bool valid(List<FormError> errors)
        {
            int errs = errors.Count;

            ID = DataAccess.validateMovieListID(ID);

            if (ID == -1)
            {
                errors.Add(new FormError() { err_code = "IDCONFLICT", err_msg = "Cannot create review at this time." });
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

            return errs == errors.Count;
        }
    }
}
