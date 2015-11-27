using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Comp3020A3
{
    public class DataAccess
    {
        public static string DATA_DIR = Environment.CurrentDirectory + "\\data";

        public static long generateID()
        {
            Random r = new Random();
            return LongRandom(10000000000000000, 99999999999999999, r);
        }

        public static long LongRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }

        public static long validateReviewID(long ID)
        {
            List<Review> reviews = readReviews();

            bool valid = false;
            int tries = 0;
            int i;

            while(!valid && tries < 100)
            {
                i = 0;
                valid = true;
                while(i < reviews.Count && valid)
                {
                    valid = reviews.ElementAt(i).ID != ID;
                    i++;
                }
                tries++;
                if(!valid)
                {
                    ID = generateID();
                }
            }

            if(tries >= 100)
            {
                return -1;
            }

            return ID;
        }

        public static long validateMovieListID(long ID)
        {
            List<MovieList> reviews = readMovieLists();

            bool valid = false;
            int tries = 0;
            int i;

            while (!valid && tries < 100)
            {
                i = 0;
                valid = true;
                while (i < reviews.Count && valid)
                {
                    valid = reviews.ElementAt(i).ID != ID;
                    i++;
                }
                tries++;
                if (!valid)
                {
                    ID = generateID();
                }
            }

            if (tries >= 100)
            {
                return -1;
            }

            return ID;
        }

        public static List<Movie> readMovies()
        {
            List<Movie> l = new List<Movie>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Movie>));

            using (FileStream fs = new FileStream(DATA_DIR + "\\movies.xml", FileMode.Open, FileAccess.Read))
            {
                l = serial.Deserialize(fs) as List<Movie>;
            }

            return l;
        }

        public static List<User> readUsers()
        {
            List<User> l = new List<User>();
            XmlSerializer serial = new XmlSerializer(typeof(List<User>));

            using (FileStream fs = new FileStream(DATA_DIR + "\\users.xml", FileMode.Open, FileAccess.Read))
            {
                l = serial.Deserialize(fs) as List<User>;
            }

            return l;
        }

        public static List<MovieList> readMovieLists()
        {
            List<MovieList> l = new List<MovieList>();
            XmlSerializer serial = new XmlSerializer(typeof(List<MovieList>));

            using (FileStream fs = new FileStream(DATA_DIR + "\\movielists.xml", FileMode.Open, FileAccess.Read))
            {
                l = serial.Deserialize(fs) as List<MovieList>;
            }

            return l;
        }

        public static List<Review> readReviews()
        {
            List<Review> r = new List<Review>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Review>));

            using (FileStream fs = new FileStream(DATA_DIR + "\\reviews.xml", FileMode.Open, FileAccess.Read))
            {
                r = serial.Deserialize(fs) as List<Review>;
            }

            return r;
        }

        public static void writeMovies(List<Movie> movies)
        {
            XmlSerializer serial = new XmlSerializer(typeof(List<Movie>));

            using (FileStream fs = new FileStream(DATA_DIR + "\\movies.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, movies);
            }
        }

        public static void writeUsers(List<User> users)
        {
            XmlSerializer serial = new XmlSerializer(typeof(List<User>));

            using (FileStream fs = new FileStream(DATA_DIR + "\\users.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, users);
            }
        }

        public static void writeMovieLists(List<MovieList> ml)
        {
            XmlSerializer serial = new XmlSerializer(typeof(List<MovieList>));

            using (FileStream fs = new FileStream(DATA_DIR + "\\movielists.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, ml);
            }
        }

        public static void writeReviews(List<Review> reviews)
        {
            XmlSerializer serial = new XmlSerializer(typeof(List<Review>));

            using (FileStream fs = new FileStream(DATA_DIR + "\\reviews.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, reviews);
            }
        }
    }
}
