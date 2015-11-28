using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    public class User
    {
        public static int MIN_UNAME_LENGTH = 6, MAX_UNAME_LENGTH = 20;
        public static int MIN_PASS_LENGTH = 8, MAX_PASS_LENGTH = 20;

        public string username { get; set; }
        public string password { get; set; }

        public List<string> following { get; set; }

        public bool isFollowing(string username)
        {
            int i = 0;

            while(i < following.Count)
            {
                if(following.ElementAt(i).Equals(username))
                {
                    return true;
                }
                i++;
            }

            return false;
        }

        public int getFollowerCount()
        {
            List<User> followers = UserManager.getFollowers(this.username);

            return followers.Count;
        }

        public Review getReview(string movie)
        {
            Review review = null;
            List<Review> reviews = ReviewManager.getReviewsByMovie(movie);
            int i = 0;

            while (i < reviews.Count && !reviews.ElementAt(i).author.Equals(username))
            {
                i++;
            }

            if(i < reviews.Count)
            {
                review = reviews.ElementAt(i);
            }

            return review;
        }

        public bool valid(List<FormError> errors)
        {
            int errs = errors.Count;

            if (username.Length < MIN_UNAME_LENGTH)
            {
                errors.Add(new FormError() { err_code = "SHORTUNAMELEN", err_msg = "Username too short (" + username.Length + "/" + MIN_UNAME_LENGTH + ")."});
            }
            else if(username.Length > MAX_UNAME_LENGTH)
            {
                errors.Add(new FormError() { err_code = "LONGUNAMELEN", err_msg = "Username too long (" + username.Length + "/" + MAX_UNAME_LENGTH + ")." });
            }

            if (password.Length < MIN_PASS_LENGTH)
            {
                errors.Add(new FormError() { err_code = "SHORTPASSLEN", err_msg = "Password too short (" + password.Length + "/" + MIN_PASS_LENGTH + ")." });
            }
            else if(password.Length > MAX_PASS_LENGTH)
            {
                errors.Add(new FormError() { err_code = "LONGPASSLEN", err_msg = "Password too long (" + password.Length + "/" + MAX_PASS_LENGTH + ")." });
            }

            //Unique username
            List<User> users = DataAccess.readUsers();
            int i = 0;

            while (i < users.Count && !username.Equals(users.ElementAt(i).username))
            {
                i++;
            }

            if (i != users.Count)
            {
                errors.Add(new FormError() { err_code = "NOTUNIQUEUNAME", err_msg = "Username '" + username + "' is taken." });
            }

            return errs == errors.Count;
        }
    }
}
