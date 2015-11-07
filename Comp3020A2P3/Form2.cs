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
        private Person person;

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
            person = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(person == null)
            {
                person = new Person(firstnamebox.Text, lastnamebox.Text, int.Parse(agebox.Text), genderbox.Text, uniyearbox.Text, phonebox.Text, addressbox.Text);
                Form1.AddPerson(person);
            }
            else
            {
                person.firstname = firstnamebox.Text;
                person.lastname = lastnamebox.Text;
                person.age = int.Parse(agebox.Text);
                person.gender = genderbox.Text;
                person.uniyear = uniyearbox.Text;
                person.phone = phonebox.Text;
                person.address = addressbox.Text;
            }

            Form1.savePeople();

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void genderbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            genderbox.Text = genderbox.SelectedItem.ToString();
        }

        private void uniyearbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uniyearbox.Text = uniyearbox.SelectedItem.ToString();
        }
    }
}
