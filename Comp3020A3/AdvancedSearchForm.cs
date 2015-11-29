using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class AdvancedSearchForm : Comp3020A3.MainForm
    {

        List<TextBox> textActors;
        int numActors;

        public AdvancedSearchForm()
        {
            InitializeComponent();

            textActors = new List<TextBox>();
            TextBox txtActor1 = new TextBox();

            txtActor1.Location = new System.Drawing.Point(13, 12);
            txtActor1.Name = "txtActor1";
            txtActor1.Size = new System.Drawing.Size(133, 20);
            pActors.Controls.Add(txtActor1);

            textActors.Add(txtActor1);
            numActors = 1;

        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {

            TextBox txtAddActor = new TextBox();
            txtAddActor.Location = new System.Drawing.Point(textActors[textActors.Count - 1].Location.X + 133 + 10, 12);
            numActors++;
            txtAddActor.Name = "txtActor" + numActors;
            txtAddActor.Size = new System.Drawing.Size(133, 20);
            pActors.Controls.Add(txtAddActor);
            textActors.Add(txtAddActor);

            btnRemoveActor.Enabled = true;
        }

        private void btnRemoveActor_Click(object sender, EventArgs e)
        {
            TextBox lastActor = textActors[numActors - 1];
            pActors.Controls.Remove(lastActor);
            textActors.RemoveAt(numActors - 1);
            //lastActor.Dispose();
            numActors--;

            if (numActors == 1)
            {
                btnRemoveActor.Enabled = false;
            }
        }
    }
}
