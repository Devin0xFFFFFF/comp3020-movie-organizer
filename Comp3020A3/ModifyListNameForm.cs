using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class ModifyListNameForm : Comp3020A3.PopupForm
    {
        private MovieList list;
        private string user;

        public ModifyListNameForm()
        {
            
        }

        public ModifyListNameForm(string user)
        {
            InitializeComponent();
            editWindowTitle("Create List");
            list = null;
            this.user = user;
            fillPopup();
        }

        public ModifyListNameForm(long ID)
        {
            MovieList list = MovieListManager.getMovieList(ID);
            InitializeComponent();
            editWindowTitle("Edit List Name");
            this.list = list;
            this.user = null;
            nameBox.Text = list.name;
            fillPopup();
        }

        public ModifyListNameForm(MovieList list)
        {
            InitializeComponent();
            editWindowTitle("Edit List Name");
            this.list = list;
            this.user = null;
            nameBox.Text = list.name;
            fillPopup();
        }

        private void fillPopup()
        {
            editTitle("Set List Name");
            errorLabel.Text = "";
        }

        protected override void okButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            List<FormError> errors;

            if (list != null)
            {
                errors = new List<FormError>();
                MovieListManager.changeListName(list.ID, name, errors);
                errorLabel.Text = FormError.getErrorMessage("TITLELEN", errors);
            }
            else
            {
                //new list
                errors = MovieListManager.createMovieList(name, user);
                errorLabel.Text = FormError.getErrorMessage("TITLELEN", errors);
            }

            if(errors.Count <= 0)
            {
                if(user != null)
                {
                    ApplicationManager.reloadForm(MovieListManager.getMovieLists(user));
                }
                else
                {
                    ApplicationManager.reloadForm(MovieListManager.getMovieLists(list.user));
                }
                Close();
            }
        }
    }
}
