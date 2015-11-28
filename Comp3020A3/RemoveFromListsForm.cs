using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class RemoveFromListsForm : Comp3020A3.ListManagementForm
    {
        private MovieList ml = null;

        public RemoveFromListsForm(MovieList list)
        {
            InitializeComponent();
            editTitle("Manage " + list.name);
            editSubTitle("List ID: " + list.ID);
            ml = list;
            fillOutForm(list);
        }

        private void fillOutForm(MovieList list)
        {
            int i;

            foreach (string movie in list.movies)
            { 
                box().Items.Add(movie);
            }

            for (i = 0; i < box().Items.Count; i++)
            {
                box().SetItemChecked(i, true);
            }
        }

        protected override void okButton_Click(object sender, EventArgs e)
        {
            int i = 0;

            //add in some reordering stuff

            foreach (string s in ml.movies)
            {
                if (!box().GetItemChecked(i))
                {
                    MovieListManager.removeFromMovieList(ml.ID, box().Items[i].ToString());
                }
                i++;
            }

            ApplicationManager.reloadForm(MovieListManager.getMovieList(ml.ID));

            Close();
        }
    }
}
