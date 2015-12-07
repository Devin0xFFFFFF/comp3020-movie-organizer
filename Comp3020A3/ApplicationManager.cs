using System;
using System.Collections.Generic;
using System.Drawing;
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

        public static List<MainForm> forms = new List<MainForm>();

        private static Stack<ApplicationState> appStack = new Stack<ApplicationState>();

        //private static Stack<MainForm> formStack = new Stack<MainForm>();
        //private static Stack<object> objectStack = new Stack<object>();

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
            else if (form.Equals("SEARCH"))
            {
                i = 5;
            }
            else if (form.Equals("RESULTS"))
            {
                i = 6;
            }
            else if (form.Equals("SCATTER"))
            {
                i = 7;
            }

            return forms.ElementAt(i);
        }

        private static void changeForm(MainForm next, object obj)
        {
            if(next != appStack.Peek().form)
            {
                appStack.Peek().form.Hide();
                next.Show();
                next.changeForm(obj);

                next.Location = appStack.Peek().form.Location;

                appStack.Push(new ApplicationState() { form = next, obj = obj, user = (loggedIn == null) ? null : loggedIn.username});
            }
            else
            {
                next.changeForm(obj);
                appStack.Peek().obj = obj;
            }
        }

        public static void changeForm(string form, object obj)
        {
            changeForm(getForm(form), obj);
        }

        public static void reloadForm()
        {
            appStack.Peek().form.changeForm(appStack.Peek().obj);
        }

        public static void reloadForm(object obj)
        {
            appStack.Peek().obj = obj;

            reloadForm();
        }

        public static void previousForm()
        {
            Point loc;
            if(appStack.Count > 1)
            {
                appStack.Peek().form.Hide();
                loc = appStack.Peek().form.Location;
                appStack.Pop();

                while((!appStack.Peek().valid() && appStack.Peek().form is ListForm && appStack.Peek().obj is List<MovieList>) ||
                    appStack.Peek().form is SignInForm && appStack.Peek().obj == null) //skip sign in page and pages that require user logged in to view
                {
                    appStack.Pop();
                }

                appStack.Peek().form.Location = loc;

                appStack.Peek().form.Show();
                appStack.Peek().form.changeForm(appStack.Peek().obj);
            }
        }

        public static void createForms(MainForm home)
        {
            forms.Add(home);
            forms.Add(new SignInForm());
            forms.Add(new ProfileForm());
            forms.Add(new MovieForm());
            forms.Add(new ListForm());
            forms.Add(new AdvancedSearchForm());
            forms.Add(new SearchResultsForm());
            forms.Add(new ScatterplotForm());

            appStack.Push(new ApplicationState() { form = home, obj = null, user = (loggedIn == null) ? null : loggedIn.username });
        }

        public static void sendData(FormData data, string form)
        {
            MainForm mainForm = getForm(form);
            mainForm.processData(data);
        }

        public static Point getCurrentFormLocation()
        {
            return appStack.Count > 0 ? appStack.Peek().form.Location : new Point(0, 0);
        }

        public static Size getCurrentFormSize()
        {
            return appStack.Count > 0 ? appStack.Peek().form.Size : new Size(0, 0);
        }

        public static void exitApplication()
        {
            Application.Exit();
        }
    }
}
