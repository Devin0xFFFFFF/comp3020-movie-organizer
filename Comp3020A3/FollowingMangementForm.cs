using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class FollowingMangementForm : Comp3020A3.ListManagementForm
    {
        private User user;

        public FollowingMangementForm(User user)
        {
            InitializeComponent();
            showActionButton(false);
            showTextBox(false);
            this.user = user;
            fillInForm(user);
        }

        private void fillInForm(User user)
        {
            editWindowTitle("Manage Following");
            editTitle("Manage Who You Follow");
            editSubTitle("");
            EditToolTip("Uncheck boxes to unfollow users. Press Ok to save changes.");

            int i;

            foreach (string f in user.following)
            {
                box().Items.Add(f);
            }

            for (i = 0; i < box().Items.Count; i++)
            {
                box().SetItemChecked(i, true);
            }
        }

        protected override void okButton_Click(object sender, EventArgs e)
        {
            int i;

            if (user != null)
            {
                for (i = user.following.Count-1; i >= 0; i--)
                {
                    if (!box().GetItemChecked(i))
                    {
                        user.unfollow(user.following[i]);
                    }
                }

                ApplicationManager.reloadForm();
            }

            Close();
        }
    }
}
