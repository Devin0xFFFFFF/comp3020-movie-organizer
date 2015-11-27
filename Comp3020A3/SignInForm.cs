using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class SignInForm : Comp3020A3.MainForm
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            changesignInLinkText("");
            usernameErrors.Text = "";
            passwordErrors.Text = "";
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            List<FormError> errors = new List<FormError>();

            if(!UserManager.login(usernameBox.Text, passwordBox.Text, errors))
            {
                usernameErrors.Text = FormError.getErrorMessage("WRONGUNAME", errors);
                passwordErrors.Text = FormError.getErrorMessage("WRONGPASS", errors);
            }
            else
            {
                Close();
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            List<FormError> errors = UserManager.createUser(usernameBox.Text, passwordBox.Text);

            if (errors.Count > 0)
            {
                usernameErrors.Text = FormError.getErrorMessage("SHORTUNAMELEN", errors) + FormError.getErrorMessage("LONGUNAMELEN", errors) + " " +
                    FormError.getErrorMessage("NOTUNIQUEUNAME", errors);
                passwordErrors.Text = FormError.getErrorMessage("SHORTPASSLEN", errors) + FormError.getErrorMessage("LONGPASSLEN", errors);
            }
            else
            {
                Close();
            }
        }
    }
}
