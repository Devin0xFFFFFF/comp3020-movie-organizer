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
    public partial class ConfirmationForm : Form
    {
        int result = -1;

        public ConfirmationForm(ref int result)
        {
            InitializeComponent();
            this.result = result;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            result = 1;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            result = 0;
            Close();
        }
    }
}
