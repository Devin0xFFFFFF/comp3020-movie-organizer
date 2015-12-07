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
        private int lastClicked;

        public ProfileForm()
        {
            InitializeComponent();
            lastClicked = -1;
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

            if (ApplicationManager.loggedIn != null && ApplicationManager.loggedIn.username.Equals(user.username))
            {
                manageFollowingButton.Show();
                editColorsButton.Show();
            }
            else
            {
                manageFollowingButton.Hide();
                editColorsButton.Hide();
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
            else if(lastClicked == e.ColumnIndex)
            {
                List<Review> reviews = (List<Review>)reviewGrid.DataSource;
                reviews.Reverse();
                reviewGrid.Refresh();
            }
            else
            {
                if(e.ColumnIndex == 2)
                {
                    ReviewManager.sortByMovie(((List<Review>)reviewGrid.DataSource));
                }
                else if(e.ColumnIndex == 3)
                {
                    ReviewManager.sortByRating(((List<Review>)reviewGrid.DataSource));
                }
                else if (e.ColumnIndex == 4)
                {
                    ReviewManager.sortByContentLength(((List<Review>)reviewGrid.DataSource));
                }
                else if (e.ColumnIndex == 5)
                {
                    ReviewManager.sortByCreationTime(((List<Review>)reviewGrid.DataSource));
                }
                else if (e.ColumnIndex == 6)
                {
                    ReviewManager.sortByDateTime(((List<Review>)reviewGrid.DataSource));
                }

                lastClicked = e.ColumnIndex;
                reviewGrid.Refresh();
            }
        }

        private void manageFollowingButton_Click(object sender, EventArgs e)
        {
            FollowingMangementForm form = new FollowingMangementForm(ApplicationManager.loggedIn);
            form.Show();
        }

        private void editColorsButton_Click(object sender, EventArgs e)
        {
            ChangeColorsForm form = new ChangeColorsForm();
            form.Show();
        }
    }
}
