using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp3020A3
{
    class ApplicationManager
    {
        public static User loggedIn = null;
        public static SearchQuery lastQuery = null;
        public static Form lastForm = null;

        public static List<MainForm> forms = new List<MainForm>();

        public static MainForm getForm(string form)
        {
            int i = 0;

            if(form.Equals("HOME"))
            {
                i = 0;
            }
            else if(form.Equals("SIGNIN"))
            {
                i = 1;
            }
            else if (form.Equals("PROFILE"))
            {
                i = 2;
            }
            else if (form.Equals("MOVIE"))
            {
                i = 3;
            }
            else if (form.Equals("LISTS"))
            {
                i = 4;
            }

            return forms.ElementAt(i);
        }

        public static void showForm(MainForm current, string next, object obj)
        {
            current.Hide();
            MainForm nextForm = getForm(next);
            nextForm.Show();
            nextForm.changeForm(obj);

        }

        public static void createForms(MainForm home)
        {
            forms.Add(home);
            forms.Add(new SignInForm());
            forms.Add(new ProfileForm());
            forms.Add(new MovieForm());
            forms.Add(new ListForm());
        }

        public static void exitApplication()
        {
            //showForm(forms.ElementAt(0), "HOME", null);
            //forms.ElementAt(0).Close();
        }
    }
}
