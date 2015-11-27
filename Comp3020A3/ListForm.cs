using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class ListForm : Comp3020A3.MainForm
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {

        }

        protected override void fillInForm(Object element)
        {
            if(element is List<MovieList>)
            {
                List<MovieList> movieLists = (List<MovieList>)element;
                fillInForm(movieLists);
            }
            else
            {
                MovieList movieList = (MovieList)element;
                fillInForm(movieList);
            }
        }

        private void fillInForm(List<MovieList> movieLists)
        {
            listTitleLabel.Text = "My Lists";

            listDataGrid.DataSource = movieLists;

            newListButton.Show();
        }

        private void fillInForm(MovieList movieList)
        {
            listTitleLabel.Text = movieList.name;

            listDataGrid.DataSource = movieList.movies;

            newListButton.Hide();
        }

        private void newListButton_Click(object sender, EventArgs e)
        {
            //either popup or something dynamic
        }
    }
}
