using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp3020_A1_Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateListView();
        }

        private void updateListView()
        {
            //listView1.Items.Add("Course Number", 3);
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
