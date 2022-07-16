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
using AccountingForPerformance.Entities;
using System.Windows.Forms.DataVisualization.Charting;

namespace AccountingForPerformance.UserControls
{
    public partial class ExamYearChartUC : UserControl, IChartView
    {
        public AcademicYear CurrentAcademicYear => cmbYears.SelectedItem as AcademicYear;
        public TypeOfAssessment CurrentTypeAssessment => cmbTypeAssessments.SelectedItem as TypeOfAssessment;
        public SchoolClass CurrentSchoolClass => cmbClasses.SelectedItem as SchoolClass;

        public Chart ChartQuality => chartQuality;
        public Chart ChartAverage => chartAverage;


        public ExamYearChartUC()
        {
            InitializeComponent();
        }

        public event Action btnCreate_OnClick;

        private void button2_Click(object sender, EventArgs e)
        {
            chartQuality.Printing.PrintPreview();
            chartAverage.Printing.PrintPreview();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate_OnClick?.Invoke();
        }

        public void SetAcademicYears(object[] years)
        {
            cmbYears.Items.Clear();
            cmbYears.Items.AddRange(years);
            if (cmbYears.Items.Count > 0)
            {
                cmbYears.SelectedIndex = 0;
            }
        }

        public void SetTypeAssessments(object[] items)
        {
            cmbTypeAssessments.Items.Clear();
            cmbTypeAssessments.Items.AddRange(items);
            if (cmbTypeAssessments.Items.Count > 0)
            {
                cmbTypeAssessments.SelectedIndex = 0;
            }
        }

        public void SetSchoolClasses(object[] items)
        {
            cmbClasses.Items.Clear();
            cmbClasses.Items.Add("Все классы");
            cmbClasses.Items.AddRange(items);
            if (cmbClasses.Items.Count > 0)
            {
                cmbClasses.SelectedIndex = 0;
            }
        }
    }
}
