using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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


        Color defaultColor;
        

        public ScatterplotForm()
        {
            InitializeComponent();

        }

        protected override void fillInForm(Object element)
        {
            query = (SearchQuery)element;

            movies = query.getList().ToArray();
            chart.Series["Series1"].Points.Clear();
            //coords = new scatterplot[movies.Length];

            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].rating != 0)
                {
                    chart.Series["Series1"].Points.AddXY((double)movies[i].year, (double)movies[i].rating);
                }
                else
                {
                    // Clicking doesn't seem to work on 0
                    chart.Series["Series1"].Points.AddXY((double)movies[i].year, (double)movies[i].rating + 0.2);
                }
                
                //coords[i].ratingY = movies[i].rating;
            }

            defaultColor = chart.Series["Series1"].Points[0].Color;

            //chart.Series["Series1"].Points.DataBindXY();

        }

        private void chart_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart.HitTest(e.X, e.Y);

            // Reset Data Point Attributes
            foreach (DataPoint point in chart.Series[0].Points)
            {
                point.Color = defaultColor;
                point.Label = "";

            }

            // If the mouse if over a data point
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                // Find selected data point
                DataPoint point = chart.Series[0].Points[result.PointIndex];

                // Change the appearance of the data point
                point.Color = Color.Green;
                point.Label = movies[result.PointIndex].title;
                
            }
            else
            {
                // Set default cursor
                this.Cursor = Cursors.Default;


            }
        }

        private void chart_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart.HitTest(e.X, e.Y);

            // If the mouse if over a data point
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                // Go to movie
                ApplicationManager.changeForm("MOVIE", new Movie(movies[result.PointIndex]));

            }
        }
    }
}
