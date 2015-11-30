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
            listDataGrid.ColumnHeadersVisible = false;
            listTitleLabel.Text = "My Lists";
            editNameButton.Hide();
            editContentsButton.Show();
            listIDLabel.Hide();

            listDataGrid.DataSource = movieLists;

            listDataGrid.Columns[0].Visible = false;
            listDataGrid.Columns[2].Visible = false;

            newListButton.Show();
        }

        private void fillInForm(MovieList movieList)
        {
            listDataGrid.ColumnHeadersVisible = true;
            listTitleLabel.Text = movieList.name;
            listIDLabel.Hide();
            listIDLabel.Text = "" + movieList.ID;

            if(ApplicationManager.loggedIn != null && ApplicationManager.loggedIn.username.Equals(movieList.user))
            {
                editNameButton.Show();
                editContentsButton.Show();
            }
            else
            {
                editNameButton.Hide();
                editContentsButton.Hide();
            }

            listDataGrid.DataSource = MovieManager.getMovies(movieList.movies);

            newListButton.Hide();
        }

        public override void processData(FormData data)
        {
            if(data.data_type.Equals("NEWLIST"))
            {
                object[] objs = new object[1];
                data.data.CopyTo(objs);
                string listName = (string)objs[0];

                //if()
            }
        }

        private void newListButton_Click(object sender, EventArgs e)
        {
            ModifyListNameForm form = new ModifyListNameForm(ApplicationManager.loggedIn.username);
            form.Show();
        }

        private void selectCell(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                if (listTitleLabel.Text.Equals("My Lists"))
                {
                    List<MovieList> lists = (List<MovieList>)listDataGrid.DataSource;
                    MovieList list = lists[e.RowIndex];


                    ApplicationManager.changeForm("LISTS", list);
                }
                else
                {
                    Movie movie = ((List<Movie>)listDataGrid.DataSource)[e.RowIndex];

                    ApplicationManager.changeForm("MOVIE", movie);
                }
            }
        }

        private void editNameButton_Click(object sender, EventArgs e)
        {
            ModifyListNameForm form = new ModifyListNameForm(long.Parse(listIDLabel.Text));
            form.Show();
        }

        private void editContentsButton_Click(object sender, EventArgs e)
        {
            RemoveFromListsForm form;

            if(listTitleLabel.Text.Equals("My Lists"))
            {
              form = new RemoveFromListsForm(MovieListManager.getMovieLists(ApplicationManager.loggedIn.username));
            }
            else
            {
              form  = new RemoveFromListsForm(MovieListManager.getMovieList(long.Parse(listIDLabel.Text)));
            }

            form.Show();
        }
    }
}
