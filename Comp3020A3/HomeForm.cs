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
            loadNewReviews();
        }

        private void loadNewMovies()
        {
            List<Movie> newMovies = DataAccess.readMovies();
            MovieManager.sortByYear(newMovies);
            newMovies = MovieManager.getMovies(newMovies, 10);

            dataGridView1.DataSource = newMovies;
        }

        private void loadNewReviews()
        {
            List<Review> newReviews = DataAccess.readReviews();
            ReviewManager.sortByDateTime(newReviews);
            newReviews = ReviewManager.getReviews(newReviews, 10);

            dataGridView2.DataSource = newReviews;
        }
    }
}
