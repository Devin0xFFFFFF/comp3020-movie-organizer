using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class FirstSignInForm : Comp3020A3.PopupForm
    {
        public FirstSignInForm()
        {
            InitializeComponent();

            hideCancel(true);
            editWindowTitle("First Login");
            editTitle("Welcome to After the Credits!");
        }

        protected override void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void enterOption(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            label.ForeColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void leaveOption(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            label.ForeColor = System.Drawing.Color.Black;
        }

        private void profileLink_Click(object sender, EventArgs e)
        {
            ApplicationManager.changeForm("PROFILE", ApplicationManager.loggedIn);
        }

        private void listsLink_Click(object sender, EventArgs e)
        {
            List<MovieList> lists = MovieListManager.getMovieLists(ApplicationManager.loggedIn.username);
            ApplicationManager.changeForm("LISTS", lists);
        }

        private void searchLink_Click(object sender, EventArgs e)
        {
            ApplicationManager.changeForm("SEARCH", new SearchQuery());
        }
    }
}
