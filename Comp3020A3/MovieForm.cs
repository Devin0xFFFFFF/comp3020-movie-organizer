using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class MovieForm : Comp3020A3.MainForm
    {
        private string order = "Date Edited";
        private string filter = "All";
        private List<Review> allReviews = null;

        public MovieForm()
        {
            InitializeComponent();
        }

        protected override void fillInForm(Object element)
        {
            Movie movie = (Movie)element;
            fillInPage(movie);
        }

        private void fillInPage(Movie movie)
        {
            movieTitleLabel.Text = movie.title;
            yearLabel.Text = "(" + movie.year + ")";
            ratingLabel.Text = "Rating: " + movie.rating;

            certificationLabel.Text = movie.certification.Length > 0 ? "Certification: " + movie.certification : "";

            genreList.Items.Clear();

            genreList.Items.Add("Genres: ");

            foreach(string genre in movie.genres)
            {
                genreList.Items.Add(genre);
            }

            genreList.BackColor = BackColor;

            directorLabel.Text = "Director: " + movie.director;
            lengthLabel.Text = "Length: " + movie.length + " min";

            actorList.Items.Clear();

            actorList.Items.Add("Actors:");

            foreach (string actor in movie.actors)
            {
                actorList.Items.Add(actor);
            }

            if(ApplicationManager.loggedIn == null)
            {
                addToListButton.Hide();
            }
            else
            {
                addToListButton.Show();
            }

            fillInReviews(movie.title);
        }

        private void fillInReviews(string movie)
        {
            allReviews = ReviewManager.getReviewsByMovie(movie);

            if(ApplicationManager.loggedIn == null)
            {
                reviewButton.Hide();
            }
            else if (ApplicationManager.loggedIn.getReview(movie) != null)
            {
                reviewButton.Show();
                reviewButton.Text = "Edit Review";
            }
            else
            {
                reviewButton.Show();
                reviewButton.Text = "Create Review";
            }

            reviewsGrid.DataSource = allReviews;
            reviewsGrid.Columns[0].Visible = false;
            reviewsGrid.Columns[2].Visible = false;

            orderBox.SelectedIndex = 0;
            filterBox.SelectedIndex = 0;
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            ModifyReviewForm form;
            Review r = ApplicationManager.loggedIn.getReview(movieTitleLabel.Text);
            if (r != null)
            {
                form = new ModifyReviewForm(r, ApplicationManager.loggedIn.username);
            }
            else
            {
                form = new ModifyReviewForm(movieTitleLabel.Text, ApplicationManager.loggedIn.username);
            }

            form.Show();
        }

        private void openReview(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                List<Review> reviews = (List<Review>)reviewsGrid.DataSource;
                Review review = reviews[e.RowIndex];

                ModifyReviewForm form = new ModifyReviewForm(review);
                form.Show();
            }
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            AddToListsForm form = new AddToListsForm(movieTitleLabel.Text);
            form.Show();
        }

        private void orderReviews(object sender, EventArgs e)
        {
            order = (string)orderBox.SelectedItem;
            formatReviews();
        }

        private void filterReviews(object sender, EventArgs e)
        {
            filter = (string)filterBox.SelectedItem;
            formatReviews();
        }

        private void formatReviews()
        {
            List<Review> reviews = new List<Review>();

            if (filter.Equals("Following"))
            {
                for(int i = 0; i < allReviews.Count; i++)
                {
                    if(ApplicationManager.loggedIn != null && ApplicationManager.loggedIn.isFollowing(allReviews[i].author))
                    {
                        reviews.Add(allReviews[i]);
                    }
                }
            }
            else
            {
                reviews = allReviews;
            }

            if (order.Equals("Author"))
            {
                ReviewManager.sortByAuthor(reviews);
            }
            else if(order.Equals("Rating"))
            {
                ReviewManager.sortByRating(reviews);
            }
            else
            {
                ReviewManager.sortByDateTime(reviews);
            }

            reviewsGrid.DataSource = reviews;
            reviewsGrid.Refresh();
        }
    }
}
