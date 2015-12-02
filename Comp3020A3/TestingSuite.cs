using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    class TestingSuite
    {
        public static void test()
        {
            DataAccess.clearDB();
            generateTestUsers();
            generateTestReviews();
            generateTestLists();
            generateTestFollowing();

        }

        private static void generateTestFollowing()
        {
            List<User> users = DataAccess.readUsers();
            Random random = new Random();

            foreach (User user in users)
            {
                int followCount = random.Next(0, users.Count);

                for(int i = 0; i <= followCount; i++)
                {
                    User other = users[i];

                    if(!user.username.Equals(other.username))
                    {
                        user.follow(other.username);
                    }
                }
            }
        }

        private static void generateTestLists()
        {
            Random random = new Random();
            List<Movie> movies = DataAccess.readMovies();
            List<User> users = DataAccess.readUsers();
            List<string> lists = getTestLists();

            foreach(User user in users)
            {
                int count = random.Next(0, 3);

                for (int i = 0; i <= count; i++)
                {
                    string l = lists[random.Next(0, lists.Count)];
                    MovieListManager.createMovieList(l, user.username);
                    List<MovieList> mls = MovieListManager.getMovieLists(user.username);
                    
                    if(mls.Count > 0)
                    {
                        MovieList list = mls[mls.Count - 1];

                        int c = random.Next(1, 10);

                        for (int j = 0; list != null && j <= c; j++)
                        {
                            MovieListManager.addToMovieList(list.ID, movies[random.Next(0, movies.Count)].title);
                        }
                    }
                }
            }
        }

        private static void generateTestReviews()
        {
            Random random = new Random();
            List<Movie> movies = DataAccess.readMovies();
            List<User> users = DataAccess.readUsers();
            List<string> reviews = getTestReviews();

            foreach (Movie movie in movies)
            {
                int count = random.Next(0, 10);

                for(int i = 0; i <= count; i++)
                {
                    User user = users[random.Next(0, users.Count)];
                    string review = reviews[random.Next(0, reviews.Count)];
                    generateTestReview(review, movie, user.username);
                }
            }
        }

        private static void generateTestReview(string review, Movie movie, string user)
        {
            string[] tokens = review.Split('|');

            string rating = tokens[0];
            string content = "";

            for(int i = 1; i < tokens.Length; i++)
            {
                if (tokens[i].Equals("MOV"))
                {
                    content += movie.title;
                }
                else if(tokens[i].Equals("DIR"))
                {
                    content += movie.director;
                }
                else if (tokens[i].Equals("LEN"))
                {
                    content += movie.length;
                }
                else if (tokens[i].Equals("GEN"))
                {
                    content += movie.genres[0];
                }
                else
                {
                    content += tokens[i];
                }
            }

            ReviewManager.createReview(user, movie.title, rating, content);
        }

        private static void generateTestUsers()
        {
            List<string> usernames = getTestUsers();

            foreach(string username in usernames)
            {
                UserManager.createUser(username, "11111111");
            }
        }

        private static List<string> getTestLists()
        {
            List<string> lists = new List<string>();

            lists.Add("favs");
            lists.Add("mylist");
            lists.Add("list1");
            lists.Add("things i watch alone");
            lists.Add("family movies");
            lists.Add("funny");
            lists.Add("interesting");
            lists.Add("good");
            lists.Add("good movies");
            lists.Add("favorites");
            lists.Add("watch again");
            lists.Add("watched");
            lists.Add("will watch");
            lists.Add("going to watch");
            lists.Add("sad");
            lists.Add("recommendations");
            lists.Add("cool movies");
            lists.Add("popular");
            lists.Add("new");
            lists.Add("want to watch");

            return lists;
        }

        private static List<string> getTestReviews()
        {
            List<string> reviews = new List<string>();

            reviews.Add("Good|I quite enjoyed|MOV|, it kept me entertained.");
            reviews.Add("Good|MOV|, was worth watching.");
            reviews.Add("Bad|I quite enjoyed|MOV|, it kept me entertained.");
            reviews.Add("Okay|It was a decent film.");
            reviews.Add("Terrible|My eyes! MY EYYYES!");
            reviews.Add("Awesome|MOV| was the best. movie. ever.");
            reviews.Add("Good|This movie has its moments.");
            reviews.Add("Good|Would watch it again.");
            reviews.Add("Bad|Wish I could get back the time I spent watching |MOV|.");
            reviews.Add("Okay|Not the best movie, but definitely good if you have nothing better to do.");
            reviews.Add("Awesome|No contest, this movie is the best!!!");
            reviews.Add("Okay|I found it alight.");
            reviews.Add("Good|In this one scene, there was this line, can't remember it, but it was super funny.");
            reviews.Add("Awesome|Theres something you need to understand about |MOV|, and that is that it is AWESOME!");
            reviews.Add("Terrible|What WAS that. It was like, the worst ever. -1/10");
            reviews.Add("Good|Fun for the whole family.");
            reviews.Add("Bad|What is |MOV|? Not good. What I'm trying to say is its bad. Not worth watching.");
            reviews.Add("Okay|Was enjoyable to a point, but nothing too special.");
            reviews.Add("Awesome|I cried throughout the whole thing. Tears of joy.");
            reviews.Add("Terrible|I think |DIR| made this movie blindfolded.");
            reviews.Add("Bad|I gave it one more chance, but I just don't enjoy movies directed by |DIR|.");
            reviews.Add("Good|DIR| always delivers when in the directors chair.");
            reviews.Add("Okay|Found it to be interesting, but not all that engaging.");
            reviews.Add("Terrible|I just watched |LEN| minutes of garbage.");
            reviews.Add("Okay|If you have the time, |MOV| is worth the watch.");
            reviews.Add("Okay|Didn't love it, didn't hate it.");
            reviews.Add("Good|Wow, |MOV| really brought out the best components of |GEN| movies.");
            reviews.Add("Okay|What to say about |MOV|... Well, there were good parts, and bad parts, but I stuck through them all.");
            reviews.Add("Terrible|What were they thinking when this was released!");
            reviews.Add("Awesome|The |GEN| genre was redefined by |MOV|!");

            return reviews;
        }

        private static List<string> getTestUsers()
        {
            List<string> users = new List<string>();

            users.Add("qqqqqq");
            users.Add("movielover");
            users.Add("starwarsfan");
            users.Add("charlie");
            users.Add("wasdqe");
            users.Add("fredbeckham");
            users.Add("hello123");
            users.Add("moviesss");
            users.Add("special");
            users.Add("denverman");
            users.Add("moviefan111");
            users.Add("ronswanson");
            users.Add("timeismoney");
            users.Add("freewilly");
            users.Add("zylophobe");
            users.Add("testing123");
            users.Add("coolkid5");
            users.Add("norefunds");
            users.Add("youtalkintome");
            users.Add("funperson678");
            users.Add("moviegroupie11");
            users.Add("lesnieknope");
            users.Add("rickandmorty");
            users.Add("dramaqueen444");
            users.Add("goldfinger");
            users.Add("007fanboy");
            users.Add("billythekid");
            users.Add("summer3");
            users.Add("thebestaround");
            users.Add("burtmacklin");

            return users;
        }
    }
}
