using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class ProfileForm : Comp3020A3.MainForm
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        protected override void fillInForm(Object element)
        {
            User user = (User)element;
            fillInProfile(user);
        }

        private void followButton_Click(object sender, EventArgs e)
        {
            if(followButton.Text.Equals("Follow") && ApplicationManager.loggedIn.follow(userTitleLabel.Text))
            {
                followButton.Text = "Unfollow";
            }
            else if(ApplicationManager.loggedIn.unfollow(userTitleLabel.Text))
            {
                followButton.Text = "Follow";
            }
        }

        private void fillInProfile(User user)
        {
            userTitleLabel.Text = user.username;

            int followers = user.getFollowerCount();

            if(followers > 0)
            {
                followerCountLabel.Text = "Followers: " + followers;
            }
            else
            {
                followerCountLabel.Text = "No Followers";
            }

            listGrid.DataSource = MovieListManager.getMovieLists(user.username);
            reviewGrid.DataSource = ReviewManager.getReviewsByAuthor(user.username);

            listGrid.Columns[0].Visible = false;
            listGrid.Columns[2].Visible = false;

            reviewGrid.Columns[0].Visible = false;
            reviewGrid.Columns[1].Visible = false;

            if (ApplicationManager.loggedIn == null || ApplicationManager.loggedIn.username.Equals(user.username))
            {
                followButton.Hide();
            }
            else
            {
                if(ApplicationManager.loggedIn != null)
                {
                    followButton.Show();
                    if (ApplicationManager.loggedIn.isFollowing(user.username))
                    {
                        followButton.Text = "Unfollow";
                    }
                    else
                    {
                        followButton.Text = "Follow";
                    }
                }
            }
        }

        private void selectList(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                List<MovieList> lists = (List<MovieList>)listGrid.DataSource;
                MovieList list = lists[e.RowIndex];
                ApplicationManager.changeForm("LISTS", list);
            }
        }

        private void selectReview(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                List<Review> reviews = (List<Review>)reviewGrid.DataSource;
                Review review = reviews[e.RowIndex];

                ModifyReviewForm form = new ModifyReviewForm(review);
                form.Show();
            }
        }
    }
}
