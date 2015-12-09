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
        bool editable;
        int selected1, selected2;

        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {

        }

        protected override void fillInForm(Object element)
        {
            editable = false;
            reorderToolTip.Hide();
            selected1 = -1;
            selected2 = -1;

            if (element is List<MovieList>)
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
            editOrderButton.Show();
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
                editOrderButton.Show();
            }
            else
            {
                editNameButton.Hide();
                editContentsButton.Hide();
                editOrderButton.Hide();
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
            form.ShowDialog();
        }

        private void selectCell(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                if (editable)
                {
                    attemptSwap(e.RowIndex);
                }
                else
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
        }

        private void attemptSwap(int index)
        {
            if (selected1 == -1)
            {
                selected1 = index;
            }
            else if(selected2 == -1)
            {
                selected2 = index;

                if (listTitleLabel.Text.Equals("My Lists"))
                {
                    MovieList list1 = ((List<MovieList>)listDataGrid.DataSource)[selected1];
                    MovieList list2 = ((List<MovieList>)listDataGrid.DataSource)[selected2];

                    ((List<MovieList>)listDataGrid.DataSource)[selected1] = list2;
                    ((List<MovieList>)listDataGrid.DataSource)[selected2] = list1;
                }
                else
                {
                    Movie item1 = ((List<Movie>)listDataGrid.DataSource)[selected1];
                    Movie item2 = ((List<Movie>)listDataGrid.DataSource)[selected2];

                    ((List<Movie>)listDataGrid.DataSource)[selected1] = item2;
                    ((List<Movie>)listDataGrid.DataSource)[selected2] = item1;
                }

                selected1 = -1;
                selected2 = -1;
                listDataGrid.ClearSelection();
                listDataGrid.Refresh();
            }
        }

        private void editNameButton_Click(object sender, EventArgs e)
        {
            editName();
        }

        public void editName()
        {
            ModifyListNameForm form = new ModifyListNameForm(long.Parse(listIDLabel.Text));
            form.ShowDialog();
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

            form.ShowDialog();
        }

        private void editOrderButton_Click(object sender, EventArgs e)
        {
            if(editable)
            {
                editable = false;
                editOrderButton.Text = "Edit Order";
                reorderToolTip.Hide();
                selected1 = -1;
                selected2 = -1;
                listDataGrid.ClearSelection();

                if (listTitleLabel.Text.Equals("My Lists"))
                {
                    List<MovieList> lists = (List<MovieList>)listDataGrid.DataSource;
                    MovieListManager.updateListOrder(ApplicationManager.loggedIn, lists);
                }
                else
                {
                    List<Movie> movies = (List<Movie>)listDataGrid.DataSource;
                    MovieListManager.updateListOrder(long.Parse(listIDLabel.Text), movies);
                }
            }
            else
            {
                editable = true;
                editOrderButton.Text = "Save Order";
                reorderToolTip.Show();
                listDataGrid.ClearSelection();
            }
        }
    }
}
