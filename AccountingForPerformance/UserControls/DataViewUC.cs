using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingForPerformance.Interfaces;

namespace AccountingForPerformance.UserControls
{
    public partial class DataViewUC : UserControl, IDataView
    {
        public DataViewUC()
        {
            InitializeComponent();
        }

        public object DataSource { get => dataGrid.DataSource; set => dataGrid.DataSource = value; }

        public object SelectRow
        {
            get
            {
                if (dataGrid.SelectedRows.Count > 0)
                    return dataGrid.SelectedRows[0];

                return null;
            }
        }
    }
}
