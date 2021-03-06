﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class SearchResultsForm : Comp3020A3.MainForm
    {
        SearchQuery query;
        int laskClickedColumn = -1;

        public SearchResultsForm()
        {
            InitializeComponent();
        }

        protected override void fillInForm(Object element)
        {
            query = (SearchQuery)element;

            lblNumber.Text = query.getList().Count + " movies found.";

            dataGridView.DataSource = query.getList();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                List<Movie> movies = (List<Movie>)dataGridView.DataSource;
                Movie[] movs = new Movie[movies.Count];
                movies.CopyTo(movs);
                Movie movie = movs[e.RowIndex];

                ApplicationManager.changeForm("MOVIE", new Movie(movie));
            }
            else if(laskClickedColumn == e.ColumnIndex)
            {
                List<Movie> movies = (List<Movie>)dataGridView.DataSource;
                movies.Reverse();
                dataGridView.Refresh();
            }
            else
            {
                if (e.ColumnIndex == 0)
                {
                    MovieManager.sortByTitle(((List<Movie>)dataGridView.DataSource));
                }
                else if (e.ColumnIndex == 1)
                {
                    MovieManager.sortByYear(((List<Movie>)dataGridView.DataSource));
                }
                else if (e.ColumnIndex == 2)
                {
                    MovieManager.sortByLength(((List<Movie>)dataGridView.DataSource));
                }
                else if (e.ColumnIndex == 3)
                {
                    MovieManager.sortByCertification(((List<Movie>)dataGridView.DataSource));
                }
                else if (e.ColumnIndex == 4)
                {
                    MovieManager.sortByDirector(((List<Movie>)dataGridView.DataSource));
                }
                else if (e.ColumnIndex == 5)
                {
                    MovieManager.sortByRating(((List<Movie>)dataGridView.DataSource));
                }
                else if (e.ColumnIndex == 6)
                {
                    MovieManager.sortByGenres(((List<Movie>)dataGridView.DataSource));
                }
                else if (e.ColumnIndex == 7)
                {
                    MovieManager.sortByActors(((List<Movie>)dataGridView.DataSource));
                }

                laskClickedColumn = e.ColumnIndex;
                dataGridView.Refresh();
            }
        }

        private void btnRefine_Click(object sender, EventArgs e)
        {
            ApplicationManager.previousForm();
        }

        private void btnScatterplot_Click(object sender, EventArgs e)
        {
            ApplicationManager.changeForm("SCATTER", query);
        }
    }


}
