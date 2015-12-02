using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class ListManagementForm : Comp3020A3.PopupForm
    {
        public ListManagementForm()
        {
            InitializeComponent();
        }

        protected void editSubTitle(string title)
        {
            subTitleLabel.Text = title;
        }

        protected string getSubTitle()
        {
            return subTitleLabel.Text;
        }

        protected void EditToolTip(string txt)
        {
            toolTipLabel.Text = txt;
        }

        protected CheckedListBox box()
        {
            return checkListBox;
        }

        protected void showTextBox(bool show)
        {
            if(show)
            {
                inputBox.Show();
            }
            else
            {
                inputBox.Hide();
            }
        }

        protected void showActionButton(bool show)
        {
            if (show)
            {
                actionButton.Show();
            }
            else
            {
                actionButton.Hide();
            }
        }

        protected void editActionButton(string text)
        {
            actionButton.Text = text;
        }

        protected string getTextBox()
        {
            return inputBox.Text;
        }

        protected virtual void actionButton_Click(object sender, EventArgs e)
        {

        }

        protected virtual void enterSearch(object sender, KeyPressEventArgs e)
        {

        }
    }
}
