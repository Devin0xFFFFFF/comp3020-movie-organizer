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
        List<Movie> movies;

        struct scatterplot
        {
            public int yearX;
            public int ratingY;
        }

        scatterplot[] coords;

        public ScatterplotForm()
        {
            InitializeComponent();

        }

        protected override void fillInForm(Object element)
        {
            query = (SearchQuery)element;

            movies = query.getList();


            coords = new scatterplot[];

            for (int i = 0; i < ; i++)
            {
                
            }

        }

    }
}
