using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingForPerformance.Presenters;

namespace AccountingForPerformance.UserControls
{
    public partial class ChartsUC : UserControl
    {
        public ChartsUC()
        {
            InitializeComponent();
        }

        private void ChartsUC_Load(object sender, EventArgs e)
        {
            ChartPresenter chartPresenter = new ChartPresenter(examYearChartUC1);
            QuarterChartPresenter quarterChartPresenter = new QuarterChartPresenter(quarterChartUC1);
        }
    }
}
