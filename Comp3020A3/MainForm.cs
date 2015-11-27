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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void changeProfileLinkText(string text)
        {
            profileLink.Text = text;
        }

        public void changemyListsLinkText(string text)
        {
            myListsLink.Text = text;
        }

        public void changesignOutLinkText(string text)
        {
            signOutLink.Text = text;
        }

        public void changesignInLinkText(string text)
        {
            signInLink.Text = text;
        }

        public void checkLoggedIn()
        {
            if (ApplicationManager.loggedIn != null)
            {
                changeProfileLinkText("Profile");
                changemyListsLinkText("My Lists");
                changesignOutLinkText("Sign Out");
                changesignInLinkText("");
            }
            else
            {
                changeProfileLinkText("");
                changemyListsLinkText("");
                changesignOutLinkText("");
                changesignInLinkText("Sign In / Up");
            }
        }

        private void profileLink_Click(object sender, EventArgs e)
        {
            //ProfileForm.Show();
        }

        private void myListsLink_Click(object sender, EventArgs e)
        {
            //MyListsForm.Show();
        }

        private void signOutLink_Click(object sender, EventArgs e)
        {
            ApplicationManager.loggedIn = null;
            checkLoggedIn();
        }

        private void signInLink_Click(object sender, EventArgs e)
        {
            //SignInForm.Show();
        }

        private void search(object sender, EventArgs e)
        {
            ApplicationManager.lastQuery = new SearchQuery() { title = searchBox.Text };
            //SearchResultsForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //AdvancedSearchForm.Show();
        }
    }
}
