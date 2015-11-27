using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    public class Movie
    {
        public string title { get; set; }
        public int year { get; set; }
        public int length { get; set; }
        public string certification { get; set; }
        public string director { get; set; }
        public int rating { get; set; }
        public List<string> genres { get; set; }
        public List<string> actors { get; set; }

        public Movie()
        {

        }

        public Movie(Movie m)
        {
            title = m.title;
            year = m.year;
            length = m.length;
            certification = m.certification;
            director = m.director;
            rating = m.rating;
            genres = m.genres;
            actors = m.actors;
        }
    }
}
