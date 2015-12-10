using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Comp3020A3;

namespace Comp3020A3
{
    public partial class ScatterplotForm : Comp3020A3.MainForm
    {

        SearchQuery query;
        Movie[] movies;
        //scatterplot[] coords;

        //struct scatterplot
        //{
        //    public int yearX;
        //    public int ratingY;
        //}

        

        public ScatterplotForm()
        {
            InitializeComponent();

        }

        protected override void fillInForm(Object element)
        {
            query = (SearchQuery)element;

            movies = query.getList().ToArray();

            //coords = new scatterplot[movies.Length];

            for (int i = 0; i < movies.Length; i++)
            {
                chart.Series["Series1"].Points.AddXY((double)movies[i].year, (double)movies[i].rating);
                //coords[i].ratingY = movies[i].rating;
            }

            //chart.Series["Series1"].Points.DataBindXY();

        }

    }
}
