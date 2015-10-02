using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp3020_A1_Part2b
{
    public partial class Form1 : Form
    {
        private bool detailed;
        private string ERROR_MESSAGE = "The provided filter string is invalid. The filter string should contain a description " +
            "of the filter, followed by the vertical bar (|) and the filter pattern.The strings for different filtering options " +
                "should also be separated by the vertical bar. Example: \"Text files (*.txt)|*.txt|All files (*.*)|*.*\"";

        public Form1()
        {
            InitializeComponent();

            Icon = SystemIcons.WinLogo;
            pictureBox1.Image = SystemIcons.Warning.ToBitmap();
            label2.Text = "";
            detailed = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(detailed)
            {
                Height = 200;
                button1.Text = "▼Details";
                label2.Text = "";
                detailed = false;
            }
            else
            {
                Height = 200 + flowLayoutPanel1.Height - 30;
                button1.Text = "▲Details";
                label2.Text = ERROR_MESSAGE;
                detailed = true;
            }
        }
    }
}
