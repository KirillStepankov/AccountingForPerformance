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

namespace AccountingForPerformance.Views
{
    public partial class ReportUC : UserControl, IReportView
    {
        public EducationalInstitution CurrentEducationalInstitution { get => cmbEducationalInstitutions.SelectedItem as EducationalInstitution; }
        public AcademicYear CurrentAcademicYear { get => cmblAcademicYears.SelectedItem as AcademicYear; }
        public object PerfomanceDataSource { get => dataPerfomances.DataSource; set { dataPerfomances.DataSource = null; dataPerfomances.DataSource = value; } }
        public object FilterDataSource { get => dataFilter.DataSource; set { dataFilter.DataSource = null; dataFilter.DataSource = value; } }

        public object SelectFilterRow
        {
            get
            {
                if (dataFilter.SelectedRows.Count == 0)
                    return null;
                else
                    return dataFilter.SelectedRows[0];
            }
        }

        public ReportUC()
        {
            InitializeComponent();
        }

        public event Action btnAdd_OnClick;
        public event Action btnRemove_OnClick;
        public event Action btnClear_OnClick;
        public event Action btnExport_OnClick;
        public event Action CurrentFilter_Changed;
        public event Action btnExportYears_OnClick;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd_OnClick?.Invoke();
        }

        public void SetEducationalInstitutions(object[] items)
        {
            cmbEducationalInstitutions.Items.Clear();
            cmbEducationalInstitutions.Items.AddRange(items);
            if (cmbEducationalInstitutions.Items.Count > 0)
            {
                cmbEducationalInstitutions.SelectedIndex = 0;
            }
        }

        public void SetAcademicYears(object[] items)
        {
            cmblAcademicYears.Items.Clear();
            cmblAcademicYears.Items.AddRange(items);
            if (cmblAcademicYears.Items.Count > 0)
            {
                cmblAcademicYears.SelectedIndex = 0;
            }
        }

        private void btnRemoveEI_Click(object sender, EventArgs e)
        {
            btnRemove_OnClick?.Invoke();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnClear_OnClick?.Invoke();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnExport_OnClick?.Invoke();
        }

        private void dataFilter_SelectionChanged(object sender, EventArgs e)
        {
            CurrentFilter_Changed?.Invoke();
        }

        private void btnExportYears_Click(object sender, EventArgs e)
        {
            btnExportYears_OnClick?.Invoke();
        }
    }
}