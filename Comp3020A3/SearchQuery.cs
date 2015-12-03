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

        public bool action, comedy, family, history, mystery, scifi, war, adventure, crime, fantasy,
            horror, news, sport, western, animation, documentary, filmnoir, music, realitytv, talkshow,
            biography, drama, gameshow, musical, romance, thriller;

        public string director { get; set; }

        public List<string> actors;

        public bool g, pg, pg13, r, nc17;

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

        public SearchQuery(String title)
        {
            movies = DataAccess.readMovies();

            for (int i = movies.Count - 1; i >= 0; i--)
            {
                if (!title.Equals("") && !movies.ElementAt(i).title.ToLower().Contains(title))
                {
                    movies.RemoveAt(i);
                }
            }
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
            for (int i = movies.Count-1; i >= 0; i--)
            //foreach (Movie movie in movies)
            {
                bool deleted = false;

                if (!title.Equals("") && !movies.ElementAt(i).title.ToLower().Contains(title.ToLower())) { movies.RemoveAt(i); deleted = true; }

                if (!deleted && !checkGenres(movies.ElementAt(i)) ) { movies.RemoveAt(i); deleted = true; }

                /* Movie must meet all criteria
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
                */


                if (!deleted && !director.Equals("") && !movies.ElementAt(i).director.ToLower().Contains(director.ToLower())) { movies.RemoveAt(i); deleted = true; }


                if (!deleted && !checkActors(movies.ElementAt(i)) ) { movies.RemoveAt(i); deleted = true; }

                /* Must match all actors
                foreach (String actor in actors)
                {
                    if (!deleted && actor != "" && !movie.actors.Contains(actor)) { movies.Remove(movie); deleted = true; }
                }
                */

                if (!deleted && !checkCertification(movies.ElementAt(i)) ) { movies.RemoveAt(i); deleted = true; }


                if (!deleted && !(movies.ElementAt(i).rating >= rating1) && !(movies.ElementAt(i).rating <= rating2)) { movies.RemoveAt(i); deleted = true; }
                if (!deleted && !(movies.ElementAt(i).year >= year1) && !(movies.ElementAt(i).year <= year2)) { movies.RemoveAt(i); deleted = true; }
                if (!deleted && !(movies.ElementAt(i).length >= length1) && !(movies.ElementAt(i).rating <= length2)) { movies.RemoveAt(i); deleted = true; }
            }

        }

        private bool checkActors(Movie movie)
        {
            bool match = false;
            List<string> movieActors = movie.actorList;

            // If all actor fields are empty, accept
            if (noActors())
            {
                match = true;
            }
            // If one actor matches, accept
            else if (matchActor(movieActors) )
            {
                match = true;
            }

            return match;
        }

        private bool matchActor(List<string> movieActors)
        {
            bool match = false;

            foreach (String movieActor in movieActors)
            {
                foreach (String actor in actors)
                {
                    // If a user inputed actor is contained in the movie, accept
                    if (!actor.Equals("") && movieActor.ToLower().Contains(actor.ToLower()))
                    {
                        match = true;
                        break;
                    }
                }

                if (match)
                {
                    break;
                }
            }

            return match;
        }

        private bool noActors()
        {
            bool none = true;

            // Check for non-empty actors
            foreach (String actor in actors)
            {
                if (!actor.Equals(""))
                {
                    none = false;
                    break;
                }
            }
            return none;
        }

        private bool checkGenres(Movie movie)
        {
            bool match = false;
            List<string> genres = movie.genreList;

            // If all genres are false, accept
            if (!action && !comedy && !family && !history && !mystery && !scifi &&
                !war && !adventure && !crime && !fantasy && !horror && !news && 
                !sport && !western && !animation && !documentary && !filmnoir && !music 
                && !realitytv && !talkshow && !biography && !drama && !gameshow && !musical 
                && !romance && !thriller)
            {
                match = true;
            }
            // If one of these is true, accept
            else if ((action && genres.Contains("Action")) || (comedy && genres.Contains("Comedy")) ||
                (family && genres.Contains("Family")) || (history && genres.Contains("History")) ||
                (mystery && genres.Contains("Mystery")) || (scifi && genres.Contains("Sci-Fi")) || 
                (war && genres.Contains("War")) || (adventure && genres.Contains("Adventure")) || 
                (crime && genres.Contains("Crime")) || (fantasy && genres.Contains("Fantasy")) || 
                (horror && genres.Contains("Horror")) || (news && genres.Contains("News")) ||
                (sport && genres.Contains("Sport")) || (western && genres.Contains("Western")) ||
                (animation && genres.Contains("Animation")) || (documentary && genres.Contains("Documentary")) || 
                (filmnoir && genres.Contains("Film-Noir")) || (music && genres.Contains("Music")) ||
                (realitytv && genres.Contains("Reality-TV")) || (talkshow && genres.Contains("Talk-Show")) || 
                (biography && genres.Contains("Biography")) || (drama && genres.Contains("Drama")) || 
                (gameshow && genres.Contains("Game-Show")) ||(musical && genres.Contains("Musical")) ||
                (romance && genres.Contains("Romance")) || (thriller && genres.Contains("Thriller")) )
            {
                match = true;
            }

            return match;
        }

        private bool checkCertification(Movie movie)
        {
            bool match = false;
            string movieCert = movie.certification;

            // If all options are false, accept
            if (!g && !pg && !pg13 && !r && !nc17)
            {
                match = true;
            }
            // If one of these is true, accept
            else if ((g && movieCert.Equals("G")) || (pg && movieCert.Equals("PG")) ||
                (pg13 && movieCert.Equals("PG-13")) || (r && movieCert.Equals("R"))
                || (nc17 && movieCert.Equals("NC-17")))
            {
                match = true;
            }
            
            return match;
        }
    }
}
