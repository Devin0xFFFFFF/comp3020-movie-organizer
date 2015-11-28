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
        public PopupForm()
        {
            InitializeComponent();
        }

        private void PopupForm_Load(object sender, EventArgs e)
        {
            Point loc = ApplicationManager.getCurrentFormLocation();
            loc.X += ApplicationManager.getCurrentFormSize().Width / 4;
            Location = loc;
        }

        protected void editTitle(string title)
        {
            titleLabel.Text = title;
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

        private void deactivationClose(object sender, EventArgs e)
        {
            Close();
        }
    }
}