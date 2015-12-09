using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class AddToListsForm : Comp3020A3.ListManagementForm
    {
        public AddToListsForm(string movie)
        {
            InitializeComponent();
            editWindowTitle("Add To Lists");
            editTitle("Add To Lists");
            EditToolTip("Check off the lists you wish to add the movie to.");
            showActionButton(true);
            editActionButton("Create New List");
            showTextBox(false);
            editSubTitle(movie);
            fillOutForm(movie);
        }

        private void fillOutForm(string movie)
        {
            List<MovieList> mls = MovieListManager.getMovieLists(ApplicationManager.loggedIn.username);
            int i;

            foreach(MovieList ml in mls)
            {
                box().Items.Add(ml.name);
            }

            for(i = 0; i < box().Items.Count; i++)
            {
                if (mls[i].contains(movie))
                {
                    box().SetItemChecked(i, true);
                }
            }
        }

        protected override void okButton_Click(object sender, EventArgs e)
        {
            List<MovieList> mls = MovieListManager.getMovieLists(ApplicationManager.loggedIn.username);
            int i = 0;

            foreach (MovieList ml in mls)
            {
                if(box().GetItemChecked(i))
                {
                    MovieListManager.addToMovieList(ml.ID, getSubTitle());
                }
                else
                {
                    MovieListManager.removeFromMovieList(ml.ID, getSubTitle());
                }
                i++;
            }

            Close();
        }

        protected override void actionButton_Click(object sender, EventArgs e)
        {
            ApplicationManager.changeForm("LISTS", MovieListManager.getMovieLists(ApplicationManager.loggedIn.username));
            Close();
        }
    }
}
