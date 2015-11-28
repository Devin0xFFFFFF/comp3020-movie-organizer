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

        public static List<MainForm> forms = new List<MainForm>();

        private static Stack<MainForm> formStack = new Stack<MainForm>();
        private static Stack<object> objectStack = new Stack<object>();

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

        private static void changeForm(MainForm next, object obj)
        {
            formStack.Peek().Hide();
            next.Show();
            next.changeForm(obj);

            formStack.Push(next);
            objectStack.Push(obj);
        }

        public static void changeForm(string form, object obj)
        {
            changeForm(getForm(form), obj);
        }

        public static void reloadForm()
        {
            formStack.Peek().changeForm(objectStack.Peek());
        }

        public static void reloadForm(object obj)
        {
            objectStack.Pop();
            objectStack.Push(obj);

            reloadForm();
        }

        public static void previousForm()
        {
            if(formStack.Count > 1)
            {
                formStack.Pop().Hide();
                objectStack.Pop();

                formStack.Peek().Show();
                formStack.Peek().changeForm(objectStack.Peek());
            }
        }

        public static void createForms(MainForm home)
        {
            forms.Add(home);
            forms.Add(new SignInForm());
            forms.Add(new ProfileForm());
            forms.Add(new MovieForm());
            forms.Add(new ListForm());

            formStack.Push(home);
            objectStack.Push(null);
        }

        public static void sendData(FormData data, string form)
        {
            MainForm mainForm = getForm(form);
            mainForm.processData(data);
        }

        public static void exitApplication()
        {
            //showForm(forms.ElementAt(0), "HOME", null);
            //forms.ElementAt(0).Close();
            //forms.ElementAt(4).Close();
        }
    }
}
