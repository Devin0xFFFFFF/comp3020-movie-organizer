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
    }
}
