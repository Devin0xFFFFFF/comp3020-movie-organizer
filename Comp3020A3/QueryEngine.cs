using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Comp3020A3
{
    public class QueryEngine
    {
        public static List<FormError> addUser(string uname, string pwd)
        {
            List<FormError> errors = new List<FormError>();

            User user = new User() { username = uname, password = pwd, following = new List<string>() };

            if(user.valid(errors))
            {
                List<User> users = DataAccess.readUsers();
                users.Add(user);
                DataAccess.writeUsers(users);
            }

            return errors;
        }

        public static List<FormError> addMovieList(string lname, string username)
        {
            List<FormError> errors = new List<FormError>();

            MovieList ml = new MovieList() { ID = DataAccess.generateID(), name = lname, user = username};

            if (ml.valid(errors))
            {
                List<MovieList> mls = DataAccess.readMovieLists();
                mls.Add(ml);
                DataAccess.writeMovieLists(mls);
            }

            return errors;
        }

        public static bool addToMovieList(long ID, string movie)
        {
            List<MovieList> ml = DataAccess.readMovieLists();

            int i = 0;

            while(i < ml.Count && ID != ml.ElementAt(i).ID)
            {
                i++;
            }

            if(i < ml.Count && !ml.ElementAt(i).contains(movie))
            {
                ml.ElementAt(i).movies.Add(movie);
                DataAccess.writeMovieLists(ml);
            }

            return false;
        }



        public static List<MovieList> getMovieLists(string username)
        {
            List <MovieList> mls = DataAccess.readMovieLists();

            int i = mls.Count - 1;

            while(i >= 0)
            {
                if(mls.ElementAt(i).user.Equals(username))
                {
                    mls.RemoveAt(i);
                    i--;
                }
            }

            return mls;
        }
    }
}
