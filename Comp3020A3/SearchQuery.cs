using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    class SearchQuery
    {
        public string title { get; set; }

        private List<Movie> movies;

        public Boolean action, comedy, family, history, mystery, scifi, war, adventure, crime, fantasy,
            horror, news, sport, western, animation, documentary, filmnoir, music, realitytv, talkshow,
            biography, drama, gameshow, musical, romance, thriller;

        public string director { get; set; }

        public List<string> actors;

        public Boolean g, pg, pg13, r, nc17;

        public int rating1, rating2;
        public int year1, year2;
        public int length1, length2;

        public SearchQuery()
        {
            title = null;
            director = null;
            actors = new List<string>();

            // Copy movie database for search
            movies = DataAccess.readMovies();
        }

        public bool verify(List<FormError> errors)
        {
            int errs = errors.Count;

            return errs == errors.Count;
        }

        public List<Movie> getList()
        {
            return movies;
        }

        public void Search()
        {
            foreach (Movie movie in movies)
            {
                bool deleted = false;

                if (title != "" && !movie.title.Contains(title)) { movies.Remove(movie); deleted = true; }

                if (!deleted && action && !movie.genres.Contains("Action")) { movies.Remove(movie); deleted = true; }
                if (!deleted && comedy && !movie.genres.Contains("Comedy")) { movies.Remove(movie); deleted = true; }
                if (!deleted && family && !movie.genres.Contains("Family")) { movies.Remove(movie); deleted = true; }
                if (!deleted && history && !movie.genres.Contains("History")) { movies.Remove(movie); deleted = true; }
                if (!deleted && mystery && !movie.genres.Contains("Mystery")) { movies.Remove(movie); deleted = true; }
                if (!deleted && scifi && !movie.genres.Contains("Sci-Fi")) { movies.Remove(movie); deleted = true; }
                if (!deleted && war && !movie.genres.Contains("War")) { movies.Remove(movie); deleted = true; }
                if (!deleted && adventure && !movie.genres.Contains("Adventure")) { movies.Remove(movie); deleted = true; }
                if (!deleted && crime && !movie.genres.Contains("Crime")) { movies.Remove(movie); deleted = true; }
                if (!deleted && fantasy && !movie.genres.Contains("Fantasy")) { movies.Remove(movie); deleted = true; }
                if (!deleted && horror && !movie.genres.Contains("Horror")) { movies.Remove(movie); deleted = true; }
                if (!deleted && news && !movie.genres.Contains("News")) { movies.Remove(movie); deleted = true; }
                if (!deleted && sport && !movie.genres.Contains("Sport")) { movies.Remove(movie); deleted = true; }
                if (!deleted && western && !movie.genres.Contains("Western")) { movies.Remove(movie); deleted = true; }
                if (!deleted && animation && !movie.genres.Contains("Animation")) { movies.Remove(movie); deleted = true; }
                if (!deleted && documentary && !movie.genres.Contains("Documentary")) { movies.Remove(movie); deleted = true; }
                if (!deleted && filmnoir && !movie.genres.Contains("Film-Noir")) { movies.Remove(movie); deleted = true; }
                if (!deleted && music && !movie.genres.Contains("Music")) { movies.Remove(movie); deleted = true; }
                if (!deleted && realitytv && !movie.genres.Contains("Reality-TV")) { movies.Remove(movie); deleted = true; }
                if (!deleted && talkshow && !movie.genres.Contains("Talk-Show")) { movies.Remove(movie); deleted = true; }
                if (!deleted && biography && !movie.genres.Contains("Biography")) { movies.Remove(movie); deleted = true; }
                if (!deleted && drama && !movie.genres.Contains("Drama")) { movies.Remove(movie); deleted = true; }
                if (!deleted && gameshow && !movie.genres.Contains("Game-Show")) { movies.Remove(movie); deleted = true; }
                if (!deleted && musical && !movie.genres.Contains("Musical")) { movies.Remove(movie); deleted = true; }
                if (!deleted && romance && !movie.genres.Contains("Romance")) { movies.Remove(movie); deleted = true; }
                if (!deleted && thriller && !movie.genres.Contains("Thriller")) { movies.Remove(movie); deleted = true; }

                if (!deleted && director != "" && !movie.director.Contains(director)) { movies.Remove(movie); deleted = true; }

                foreach (String actor in actors)
                {
                    if (!deleted && actor != "" && !movie.actors.Contains(actor)) { movies.Remove(movie); deleted = true; }
                }

                // TODO: Certification (change to radio buttons)
                //if (!deleted && g && !movie.certification.Equals("G")) { movies.Remove(movie); deleted = true; }

                if (!deleted && !(movie.rating >= rating1) && !(movie.rating <= rating2)) { movies.Remove(movie); deleted = true; }
                if (!deleted && !(movie.year >= year1) && !(movie.year <= year2)) { movies.Remove(movie); deleted = true; }
                if (!deleted && !(movie.length >= length1) && !(movie.rating <= length2)) { movies.Remove(movie); deleted = true; }
            }

            throw new NotImplementedException();
        }
    }
}
