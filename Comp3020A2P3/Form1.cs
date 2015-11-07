using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Comp3020A2P3
{
    public partial class Form1 : Form
    {
        string XML_FILE = "../../people.xml";
        List<Person> people;
        int PERSON_ATTRS = 7;

        public Form1()
        {
            InitializeComponent();

            people = new List<Person>();

            getPeople();
        }

        private void getPeople()
        {
            XmlTextReader reader = new XmlTextReader(XML_FILE);

            people = new List<Person>();
            List<string> attrs;

            while(reader.Read())
            {
                if(reader.NodeType == XmlNodeType.Element && reader.Name == "person")
                {
                    attrs = new List<string>();
                    for (int i = 0; i < PERSON_ATTRS; i++)
                    {
                        while (reader.NodeType != XmlNodeType.Text)
                        {
                            reader.Read();
                        }
                        attrs.Add(reader.Value);
                        reader.Read();
                    }
                    people.Add(new Person(attrs[0], attrs[1], int.Parse(attrs[2]), attrs[3], attrs[4], attrs[5], attrs[6]));
                }
            }

            foreach(Person p in people)
            {
                Console.WriteLine(p.firstname);
            }
        }

        private void savePeople()
        {
            XmlWriter writer = XmlWriter.Create("../../out.xml");
            writer.WriteStartDocument();

            writer.WriteStartElement("people");
            foreach(Person p in people)
            {
                writer.WriteStartElement("person");
                writer.WriteElementString("firstname", p.firstname);
                writer.WriteElementString("lastname", p.lastname);
                writer.WriteElementString("age", "" + p.age);
                writer.WriteElementString("gender", p.gender);
                writer.WriteElementString("uniyear", p.uniyear);
                writer.WriteElementString("phone", p.phone);
                writer.WriteElementString("address", p.address);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    class Person
    {
        public string firstname, lastname;
        public int age;
        public string gender, uniyear, phone, address;

        public Person(string firstname, string lastname, int age, string gender, string uniyear, string phone, string address)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.gender = gender;
            this.uniyear = uniyear;
            this.phone = phone;
            this.address = address;
        }
    }
}
