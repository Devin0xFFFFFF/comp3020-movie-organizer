using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp3020A2P3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void Update(Person p)
        {
            firstnamebox.Text = p.firstname;
            lastnamebox.Text = p.lastname;
            agebox.Text = "" + p.age;
            genderbox.Text = p.gender;
            uniyearbox.Text = p.uniyear;
            phonebox.Text = p.phone;
            addressbox.Text = p.address;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
