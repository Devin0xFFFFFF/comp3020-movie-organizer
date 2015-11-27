using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class HomeForm : Comp3020A3.MainForm
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            checkLoggedIn();
            loadNewMovies();
        }

        private void checkLoggedIn()
        {
            if(ApplicationManager.loggedIn != null)
            {
                changeProfileLinkText ("Profile");
                changemyListsLinkText("My Lists");
                changesignOutLinkText("Sign Out");
                changesignInLinkText("");
            }
            else
            {
                changeProfileLinkText("");
                changemyListsLinkText("");
                changesignOutLinkText("");
                changesignInLinkText("Sign In / Up");
            }
        }

        private void loadNewMovies()
        {
            List<Movie> newMovies = DataAccess.readMovies();
            MovieManager.sortByYear(newMovies);
            newMovies = MovieManager.getMovies(newMovies, 10);

            dataGridView1.DataSource = newMovies;
        }
    }
}
