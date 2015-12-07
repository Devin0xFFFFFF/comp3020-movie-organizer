using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class ScatterplotForm : Comp3020A3.MainForm
    {

        SearchQuery query;

        public ScatterplotForm()
        {
            InitializeComponent();

            this.Invalidate();
            //Pen pen = new Pen(Color.Black);
            //panel.CreateGraphics().DrawLine(pen, new Point(0, 0), new Point(panel.Size.Height, 0));
            //this.Invalidate();
        }

        protected override void fillInForm(Object element)
        {
            query = (SearchQuery)element;

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            Graphics graph = panel.CreateGraphics();
            graph.DrawLine(pen, new Point(0, 0), new Point(0, panel.Size.Height));
            graph.DrawLine(pen, new Point(0, panel.Size.Height), new Point(panel.Size.Width, panel.Size.Height));
            //this.Invalidate();
        }
    }
}
