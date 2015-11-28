using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class ModifyReviewForm : Comp3020A3.PopupForm
    {
        private string user = null, movie = null;
        private Review review = null;

        public ModifyReviewForm(string movie, string user)
        {
            InitializeComponent();

            errorLabel.Text = "";
            editTitle("Review for " + movie);
            authorLabel.Text = "";

            titleBox.Enabled = true;
            contentBox.Enabled = true;
            deleteButton.Hide();

            titleBox.Text = "";
            contentBox.Text = "";
            
            this.user = user;
            this.movie = movie;
        }

        public ModifyReviewForm(Review review)
        {
            InitializeComponent();

            errorLabel.Text = "";
            editTitle("Review for " + review.movie);
            authorLabel.Text = review.author;

            titleBox.Enabled = false;
            contentBox.Enabled = false;

            titleBox.Text = review.title;
            contentBox.Text = review.content;
            deleteButton.Hide();

            this.review = review;
            user = null;
            movie = null;
        }

        public ModifyReviewForm(Review review, string user)
        {
            InitializeComponent();

            errorLabel.Text = "";
            editTitle("Review for " + review.movie);
            authorLabel.Text = "";

            titleBox.Enabled = true;
            contentBox.Enabled = true;

            titleBox.Text = review.title;
            contentBox.Text = review.content;
            deleteButton.Show();

            this.user = user;
            this.review = review;
            movie = null;
        }

        private void authorLabel_Click(object sender, EventArgs e)
        {
            ApplicationManager.changeForm("PROFILE", UserManager.getUser(authorLabel.Text));
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ReviewManager.destroyReview(review.ID);

            ApplicationManager.reloadForm();
            Close();
        }

        protected override void okButton_Click(object sender, EventArgs e)
        {
            List<FormError> errors = null;

            if (movie != null)
            {
                errors = ReviewManager.createReview(user, movie, titleBox.Text, contentBox.Text);
                errorLabel.Text = FormError.getErrorMessage("TITLELEN", errors) + " " + 
                    FormError.getErrorMessage("CONTENTLEN", errors) + " " +
                    FormError.getErrorMessage("IDCONFLICT", errors);
            }
            else if(user != null)
            {
                errors = new List<FormError>();
                review.title = titleBox.Text;
                review.content = contentBox.Text;

                if (!ReviewManager.saveReview(review, errors))
                {
                    errorLabel.Text = FormError.getErrorMessage("TITLELEN", errors) + " " + FormError.getErrorMessage("CONTENTLEN", errors);
                }
            }

            if(errors == null || errors.Count <= 0)
            {
                if(movie != null)
                {
                    ApplicationManager.reloadForm(MovieManager.getMovie(movie));
                }
                else
                {
                    ApplicationManager.reloadForm(MovieManager.getMovie(review.movie));
                }

                Close();
            }
        }
    }
}
