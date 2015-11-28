using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    class UserManager
    {
        public static List<FormError> createUser(string uname, string pwd)
        {
            List<FormError> errors = new List<FormError>();

            User user = new User() { username = uname, password = pwd, following = new List<string>() };

            if (user.valid(errors))
            {
                List<User> users = DataAccess.readUsers();
                users.Add(user);
                DataAccess.writeUsers(users);
            }

            return errors;
        }

        public static User getUser(string uname)
        {
            List<User> users = DataAccess.readUsers();
            User user = null;
            int i = 0;

            while (i < users.Count && !users.ElementAt(i).username.Equals(uname))
            {
                i++;
            }

            if(i < users.Count)
            {
                user = users.ElementAt(i);
            }

            return user;
        }

        public static bool destroyUser(string uname)
        {
            List<User> users = DataAccess.readUsers();
            int i = 0;
            bool removed = false;

            while (i < users.Count && !removed)
            {
                if (users.ElementAt(i).username.Equals(uname))
                {
                    users.RemoveAt(i);
                    removed = true;
                }

                i++;
            }

            return removed;
        }

        public static bool login(string uname, string pwd, List<FormError> errors)
        {
            if(ApplicationManager.loggedIn == null)
            {
                List<User> users = DataAccess.readUsers();
                User user = null;
                int i = 0;

                while (i < users.Count && user == null)
                {
                    if (users.ElementAt(i).username.Equals(uname))
                    {
                        user = users.ElementAt(i);
                    }
                    i++;
                }

                if (user != null)
                {
                    if(user.password.Equals(pwd))
                    {
                        ApplicationManager.loggedIn = new User() { username = user.username, password = user.password, following = user.following };
                        return true;
                    }
                    errors.Add(new FormError { err_code = "WRONGPASS", err_msg = "Incorrect password." });
                }
                else
                {
                    errors.Add(new FormError { err_code = "WRONGUNAME", err_msg = "Incorrect Username." });
                }
            }

            return false;
        }

        public static void logout()
        {
            ApplicationManager.loggedIn = null;
        }

        public static List<User> getFollowers(string user)
        {
            List<User> users = DataAccess.readUsers();
            int i;

            for(i = users.Count - 1; i >= 0; i--)
            {
                if(!users.ElementAt(i).isFollowing(user))
                {
                    users.RemoveAt(i);
                }
            }

            return users;
        }

        public static bool saveUser(User user)
        {
            List<User> users = DataAccess.readUsers();
            int i = 0;

            while(i < users.Count && !users.ElementAt(i).username.Equals(user.username))
            {
                i++;
            }

            if(i < users.Count)
            {
                users.ElementAt(i).following = user.following;
                DataAccess.writeUsers(users);
                return true;
            }

            return false;
        }
    }
}
