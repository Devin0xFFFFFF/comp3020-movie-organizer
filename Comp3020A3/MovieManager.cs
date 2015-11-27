using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    class MovieManager
    {
        //queryMovies()

        public static void convertXMLFormats(string xml_in_path)
        {
            List<Movie> movies = new List<Movie>();



            DataAccess.writeMovies(movies);
        }
    }
}
