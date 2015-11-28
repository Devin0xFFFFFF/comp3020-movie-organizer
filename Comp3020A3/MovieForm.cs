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
            certificationLabel.Text = movie.certification;

            genreList.Items.Clear();

            foreach(string genre in movie.genres)
            {
                genreList.Items.Add(genre);
            }

            directorLabel.Text = "Director: " + movie.director;
            lengthLabel.Text = "Length: " + movie.length + " min";

            actorList.Items.Add("Actors:");

            actorList.Items.Clear();

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
            List<Review> reviews = ReviewManager.getReviewsByMovie(movie);

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

            reviewsGrid.DataSource = reviews;
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
            List<Review> reviews = (List<Review>)reviewsGrid.DataSource;
            Review review = reviews[e.RowIndex];

            ModifyReviewForm form = new ModifyReviewForm(review);
            form.Show();
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            AddToListsForm form = new AddToListsForm(movieTitleLabel.Text);
            form.Show();
        }
    }
}
