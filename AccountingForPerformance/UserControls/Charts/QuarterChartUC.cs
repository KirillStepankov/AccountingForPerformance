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

namespace AccountingForPerformance.UserControls.Charts
{
    public partial class QuarterChartUC : UserControl, IQuarterChartView
    {
        public QuarterChartUC()
        {
            InitializeComponent();
        }

        public AcademicYear CurrentAcademicYear => cmbYears.SelectedItem as AcademicYear;

        public EducationalInstitution CurrentEducationalInstitution => cmbEducationalInstitutions.SelectedItem as EducationalInstitution;

        public SchoolClass CurrentSchoolClass => cmbClasses.SelectedItem as SchoolClass;

        public Chart Chart => chartQuarter;

        public event Action btnCreate_OnClick;

        public void SetAcademicYears(object[] items)
        {
            cmbYears.Items.Clear();
            cmbYears.Items.AddRange(items);
            if (cmbYears.Items.Count > 0)
            {
                cmbYears.SelectedIndex = 0;
            }
        }

        public void SetEducationalInstitution(object[] items)
        {
            cmbEducationalInstitutions.Items.Clear();
            cmbEducationalInstitutions.Items.AddRange(items);
            if (cmbEducationalInstitutions.Items.Count > 0)
            {
                cmbEducationalInstitutions.SelectedIndex = 0;
            }
        }

        public void SetSchoolClasses(object[] items)
        {
            cmbClasses.Items.Clear();
            cmbClasses.Items.AddRange(items);
            if (cmbClasses.Items.Count > 0)
            {
                cmbClasses.SelectedIndex = 0;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate_OnClick?.Invoke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chartQuarter.Printing.PrintPreview();
        }
    }
}
