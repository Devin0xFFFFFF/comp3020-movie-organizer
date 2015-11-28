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
            ApplicationManager.loggedIn = new User() { username = "bobafett2", password = "", following = new List<string>() };
            ApplicationManager.createForms(this);
            checkLoggedIn();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            loadNewMovies();
            loadNewReviews();

            //Console.WriteLine(YesNoResult.yes());
        }

        private void loadNewMovies()
        {
            List<Movie> newMovies = DataAccess.readMovies();
            MovieManager.sortByYear(newMovies);
            newMovies = MovieManager.getMovies(newMovies, 30);

            dataGridView1.DataSource = newMovies;
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

            followingReviews = ReviewManager.getReviews(followingReviews, 30);

            if(followingReviews.Count < 30)
            {
                for(i = 0; i < 30 - followingReviews.Count && i < newReviews.Count; i++)
                {
                    followingReviews.Add(newReviews[i]);
                }
            }

            dataGridView2.DataSource = followingReviews;
            dataGridView2.Columns[0].Visible = false;
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
        }
    }
}
