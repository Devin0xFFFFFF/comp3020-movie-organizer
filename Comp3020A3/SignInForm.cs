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

        }

        protected override void fillInForm(object element)
        {
            changesignInLinkText("");
            usernameErrors.Text = "";
            passwordErrors.Text = "";

            usernameBox.Text = "";
            passwordBox.Text = "";
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            signIn();
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
                if(UserManager.login(usernameBox.Text, passwordBox.Text, errors))
                {
                    ApplicationManager.changeForm("HOME", null);
                    FirstSignInForm form = new FirstSignInForm();
                    form.Show();
                }
            }
        }

        private void signIn()
        {
            List<FormError> errors = new List<FormError>();

            if (!UserManager.login(usernameBox.Text, passwordBox.Text, errors))
            {
                usernameErrors.Text = FormError.getErrorMessage("WRONGUNAME", errors);
                passwordErrors.Text = FormError.getErrorMessage("WRONGPASS", errors);
            }
            else
            {
                ApplicationManager.changeForm("HOME", null);
            }
        }

        private void loginOnEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                signIn();
            }
        }
    }
}
