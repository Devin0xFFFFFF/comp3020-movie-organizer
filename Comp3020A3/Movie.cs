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
        public string genres { get; set; }
        public string actors { get; set; }
        public List<string> genreList { get; set; }
        public List<string> actorList { get; set; }

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
            genreList = m.genreList;
            actorList = m.actorList;
        }

        public void initLists()
        {
            genres = initList(genreList);
            actors = initList(actorList);
        }

        private string initList(List<string> list)
        {
            string strlist = "";

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    strlist += list[i] + ", ";
                }

                strlist += list[list.Count - 1];
            }

            return strlist;
        }
    }
}
