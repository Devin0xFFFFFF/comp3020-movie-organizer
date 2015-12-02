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
        public static int REVIEWS = 20;

        public HomeForm()
        {
            InitializeComponent();
            
            ApplicationManager.createForms(this);
            checkLoggedIn();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            loadNewMovies();
            loadNewReviews();
            loadPopularReviews();
        }

        private void loadNewMovies()
        {
            List<Movie> newMovies = DataAccess.readMovies();
            MovieManager.sortByYear(newMovies);
            newMovies = MovieManager.getMovies(newMovies, 18);

            dataGridView1.DataSource = newMovies;

            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void loadNewReviews()
        {
            List<Review> newReviews = DataAccess.readReviews();
            List<Review> followingReviews = new List<Review>();

            int i = newReviews.Count - 1;

            //Remove your own reviews, collect following ones to be displayed first

            if(ApplicationManager.loggedIn != null)
            {
                while (i >= 0)
                {
                    if(ApplicationManager.loggedIn.isFollowing(newReviews[i].author))
                    {
                        followingReviews.Add(newReviews[i]);
                        newReviews.RemoveAt(i);
                    }
                    else if (newReviews[i].author.Equals(ApplicationManager.loggedIn.username))
                    {
                        newReviews.RemoveAt(i);
                    }
                    i--;
                }

                ReviewManager.sortByDateTime(newReviews);
                ReviewManager.sortByDateTime(followingReviews);
            }

            followingReviews = ReviewManager.getReviews(followingReviews, REVIEWS);

            if(followingReviews.Count < REVIEWS)
            {
                int end = REVIEWS - followingReviews.Count;
                end = (newReviews.Count - end > 0) ? end : newReviews.Count;

                for (i = 0; i < end; i++)
                {
                    followingReviews.Add(newReviews[i]);
                }
            }

            ReviewManager.sortByDateTime(followingReviews);

            dataGridView2.DataSource = followingReviews;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
        }

        private void loadPopularReviews()
        {
            List<Review> newReviews = DataAccess.readReviews();
            ReviewManager.sortByDateTime(newReviews);
            newReviews = ReviewManager.getReviews(newReviews, 100);
            ReviewManager.sortByAuthorFollowers(newReviews);
            List<Review> popularReviews = new List<Review>();

            for(int i = 0; i <= REVIEWS && i < newReviews.Count; i++)
            {
                popularReviews.Add(newReviews[i]);
            }

            ReviewManager.sortByAuthorFollowers(popularReviews);

            dataGridView3.DataSource = popularReviews;
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[4].Visible = false;
            dataGridView3.Columns[5].Visible = false;
            dataGridView3.Columns[6].Visible = false;
        }

        protected override void fillInForm(Object element)
        {
            loadNewReviews();
        }

        private void viewMoviePage(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                List<Movie> movies = (List<Movie>)dataGridView1.DataSource;
                Movie[] movs = new Movie[movies.Count];
                movies.CopyTo(movs);
                Movie movie = movs[e.RowIndex];

                ApplicationManager.changeForm("MOVIE", new Movie(movie));
            }
            else
            {
                Console.WriteLine(e.ColumnIndex);
                if (e.ColumnIndex == 0)
                {
                    MovieManager.sortByTitle(((List<Movie>)dataGridView1.DataSource));
                }
                else if (e.ColumnIndex == 1)
                {
                    MovieManager.sortByYear(((List<Movie>)dataGridView1.DataSource));
                }
                else if (e.ColumnIndex == 5)
                {
                    MovieManager.sortByRating(((List<Movie>)dataGridView1.DataSource));
                }

                dataGridView1.Refresh();
            }
        }

        private void openReview(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                List<Review> reviews = (List<Review>)dataGridView2.DataSource;
                Review review = reviews[e.RowIndex];

                ModifyReviewForm form = new ModifyReviewForm(review);
                form.Show();
            }
            else
            {
                if(e.ColumnIndex == 1)
                {
                    ReviewManager.sortByAuthor(((List<Review>)dataGridView2.DataSource));
                }
                else if(e.ColumnIndex == 2)
                {
                    ReviewManager.sortByMovie(((List<Review>)dataGridView2.DataSource));
                }
                else if(e.ColumnIndex == 3)
                {
                    ReviewManager.sortByRating(((List<Review>)dataGridView2.DataSource));
                }

                dataGridView2.Refresh();
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openReview2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                List<Review> reviews = (List<Review>)dataGridView3.DataSource;
                Review review = reviews[e.RowIndex];

                ModifyReviewForm form = new ModifyReviewForm(review);
                form.Show();
            }
            else
            {
                if (e.ColumnIndex == 1)
                {
                    ReviewManager.sortByAuthor(((List<Review>)dataGridView3.DataSource));
                }
                else if (e.ColumnIndex == 2)
                {
                    ReviewManager.sortByMovie(((List<Review>)dataGridView3.DataSource));
                }
                else if (e.ColumnIndex == 3)
                {
                    ReviewManager.sortByRating(((List<Review>)dataGridView3.DataSource));
                }

                dataGridView3.Refresh();
            }
        }
    }
}
