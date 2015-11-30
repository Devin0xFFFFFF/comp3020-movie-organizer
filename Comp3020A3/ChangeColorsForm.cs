using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class ChangeColorsForm : Comp3020A3.PopupForm
    {
        private int[] colors;

        public ChangeColorsForm()
        {
            InitializeComponent();
            editWindowTitle("Change Colors");
            editTitle("Change Interface Colors");

            colors = new int[ApplicationManager.loggedIn.userColors.Count];
            ApplicationManager.loggedIn.userColors.CopyTo(colors);
        }

        protected override void okButton_Click(object sender, EventArgs e)
        {
            UserManager.setUserColor(ApplicationManager.loggedIn, 0, colors[0]);
            UserManager.setUserColor(ApplicationManager.loggedIn, 1, colors[1]);
            UserManager.setUserColor(ApplicationManager.loggedIn, 2, colors[2]);

            ApplicationManager.reloadForm();
            Close();
        }

        private void pickWindowColorButton_Click(object sender, EventArgs e)
        {
            holdForDialog(true);
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                colors[0] = colorDialog1.Color.ToArgb();
            }
            holdForDialog(false);
        }

        private void pickTaskbarColorButton_Click(object sender, EventArgs e)
        {
            holdForDialog(true);
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                colors[1] = colorDialog1.Color.ToArgb();
            }
            holdForDialog(false);
        }

        private void pickPopupWindowColorButton_Click(object sender, EventArgs e)
        {
            holdForDialog(true);
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                colors[2] = colorDialog1.Color.ToArgb();
            }
            holdForDialog(false);
        }
    }
}
