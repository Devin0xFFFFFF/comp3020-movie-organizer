using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class PopupForm : Form
    {
        private bool holdDialog = false;

        public PopupForm()
        {
            InitializeComponent();
        }

        private void PopupForm_Load(object sender, EventArgs e)
        {
            Point loc = ApplicationManager.getCurrentFormLocation();
            loc.X += ApplicationManager.getCurrentFormSize().Width / 4;
            Location = loc;

            if(ApplicationManager.loggedIn != null)
            {
                List<int> colors = ApplicationManager.loggedIn.userColors;

                if(colors != null && colors.Count > 2)
                {
                    BackColor = Color.FromArgb(colors[2]);
                }
            }
            else
            {
                List<int> colors = UserManager.getDefaultUserColors();
                BackColor = Color.FromArgb(colors[2]);
            }
        }

        protected void editWindowTitle(string title)
        {
            this.Text = title;
        }

        protected void editTitle(string title)
        {
            titleLabel.Text = title;
        }

        protected string getTitle()
        {
            return titleLabel.Text;
        }

        protected void editOkButton(string txt)
        {
            okButton.Text = txt;
        }

        protected void editCancelButton(string txt)
        {
            cancelButton.Text = txt;
        }

        protected virtual void okButton_Click(object sender, EventArgs e)
        {

        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void hideCancel(bool hide)
        {
            if(hide)
            {
                buttonPanel.Location = new Point(151, 7);
                cancelButton.Hide();
            }
            else
            {
                buttonPanel.Location = new Point(101, 7);
                cancelButton.Show();
            }
        }

        protected void holdForDialog(bool hold)
        {
            holdDialog = hold;
        }

        protected bool holdingForDialog()
        {
            return holdDialog;
        }

        private void deactivationClose(object sender, EventArgs e)
        {
            if(!holdingForDialog())
            {
                Close();
            }
        }

        protected virtual void enterPopupTitle(object sender, EventArgs e)
        {

        }

        protected virtual void leavePopupTitle(object sender, EventArgs e)
        {

        }

        protected virtual void clickTitle(object sender, EventArgs e)
        {

        }

        protected void setTitleHover()
        {
            titleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
        }

        protected void setTitleNormal()
        {
            titleLabel.ForeColor = System.Drawing.Color.Black;
        }
    }
}