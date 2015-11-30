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
            editWindowTitle("Create Review");
            editTitle(movie);
            authorLabel.Text = "";
            authorFrontLabel.Text = "";

            ratingBox.Enabled = true;
            contentBox.Enabled = true;
            deleteButton.Hide();

            ratingBox.Text = "";
            contentBox.Text = "";
            
            this.user = user;
            this.movie = movie;
        }

        public ModifyReviewForm(Review review)
        {
            InitializeComponent();

            errorLabel.Text = "";
            editWindowTitle("Examine Review");
            editTitle(review.movie);
            reviewTimeLabel.Text = "Reviewed at " + review.lastEdited.ToShortTimeString() + " on " + review.lastEdited.ToShortDateString();

            if(ApplicationManager.loggedIn != null && ApplicationManager.loggedIn.username.Equals(review.author))
            {
                authorLabel.Text = "";
                authorFrontLabel.Text = "";
                ratingBox.Enabled = true;
                contentBox.Enabled = true;
                deleteButton.Show();
                this.user = review.author;
            }
            else
            {
                authorLabel.Text = review.author;
                authorFrontLabel.Text = "Author:";
                ratingBox.Enabled = false;
                contentBox.Enabled = false;
                deleteButton.Hide();
                user = null;
            }

            ratingBox.Text = review.rating;
            contentBox.Text = review.content;

            this.review = review;
            movie = null;
        }

        public ModifyReviewForm(Review review, string user)
        {
            InitializeComponent();

            errorLabel.Text = "";
            editWindowTitle("Edit Review");
            editTitle(review.movie);
            authorLabel.Text = "";
            authorFrontLabel.Text = "";
            reviewTimeLabel.Text = "Reviewed at " + review.lastEdited.ToShortTimeString() + " on " + review.lastEdited.ToShortDateString();

            ratingBox.Enabled = true;
            contentBox.Enabled = true;

            ratingBox.Text = review.rating;
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

        private void authorLabelMouseEnter(object sender, EventArgs e)
        {
            authorLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void authorLabelMouseLeave(object sender, EventArgs e)
        {
            authorLabel.ForeColor = System.Drawing.Color.Black;
        }

        protected override void okButton_Click(object sender, EventArgs e)
        {
            List<FormError> errors = null;

            if (movie != null)
            {
                errors = ReviewManager.createReview(user, movie, ratingBox.Text, contentBox.Text);
                errorLabel.Text = FormError.getErrorMessage("NORATING", errors) + " " + 
                    FormError.getErrorMessage("CONTENTLEN", errors) + " " +
                    FormError.getErrorMessage("IDCONFLICT", errors);
            }
            else if(user != null)
            {
                errors = new List<FormError>();
                review.rating = ratingBox.Text;
                review.content = contentBox.Text;

                if (!ReviewManager.saveReview(review, errors))
                {
                    errorLabel.Text = FormError.getErrorMessage("NORATING", errors) + " " + FormError.getErrorMessage("CONTENTLEN", errors);
                }
            }

            if(errors == null || errors.Count <= 0)
            {
                ApplicationManager.reloadForm();

                Close();
            }
        }

        protected override void enterPopupTitle(object sender, EventArgs e)
        {
            setTitleHover();
        }

        protected override void leavePopupTitle(object sender, EventArgs e)
        {
            setTitleNormal();
        }

        protected override void clickTitle(object sender, EventArgs e)
        {
            ApplicationManager.changeForm("MOVIE", MovieManager.getMovie(getTitle()));
            Close();
        }
    }
}
