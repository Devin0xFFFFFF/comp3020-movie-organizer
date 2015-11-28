using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class AddToListsForm : Comp3020A3.PopupForm
    {
        public AddToListsForm(string movie)
        {
            InitializeComponent();
            editTitle("Add To Lists");
            movieTitleLabel.Text = movie;
            fillOutForm(movie);
        }

        private void fillOutForm(string movie)
        {
            List<MovieList> mls = MovieListManager.getMovieLists(ApplicationManager.loggedIn.username);
            int i;

            foreach(MovieList ml in mls)
            {
                movieLists.Items.Add(ml.name);
            }

            for(i = 0; i < movieLists.Items.Count; i++)
            {
                if (mls[i].contains(movie))
                {
                    movieLists.SetItemChecked(i, true);
                }
            }
        }

        protected override void okButton_Click(object sender, EventArgs e)
        {
            List<MovieList> mls = MovieListManager.getMovieLists(ApplicationManager.loggedIn.username);
            int i = 0;

            foreach (MovieList ml in mls)
            {
                if(movieLists.GetItemChecked(i))
                {
                    MovieListManager.addToMovieList(ml.ID, movieTitleLabel.Text);
                }
                else
                {
                    MovieListManager.removeFromMovieList(ml.ID, movieTitleLabel.Text);
                }
                i++;
            }

            Close();
        }
    }
}
