using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Comp3020A3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Review> l = new List<Review>();

            //l.Add(new Review() { ID = DataAccess.generateID(), author = "bobafett" });

            //DataAccess.writeReviews(l);

            ReviewManager.createReview("bobafett", "transformers", "this sucked", "This was an awful movie.");

            //QueryEngine.addToMovieList(439512116797564928, "superman");
            //QueryEngine.addUser("tommyt", "12345678");
            //QueryEngine.addMovieList("action", "tommyt");

            //List <User> users = DataAccess.readUsers();
            //dataGridView1.DataSource = users;
        }
    }
}
