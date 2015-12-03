using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comp3020A3
{
    public partial class SearchResultsForm : Comp3020A3.MainForm
    {
        SearchQuery query;

        public SearchResultsForm()
        {
            InitializeComponent();
        }

        protected override void fillInForm(Object element)
        {
            query = (SearchQuery)element;

            dataGridView.DataSource = query.getList();
        }
    }


}
