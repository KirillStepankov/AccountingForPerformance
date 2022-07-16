using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AccountingForPerformance.Entities;
using AccountingForPerformance.Interfaces;
using AccountingForPerformance.LogicalEntities;
using AccountingForPerformance.Presenters;

namespace AccountingForPerformance.UserControls
{
    public partial class ExamUC : UserControl, IExamsView
    {
        //private PerformancePresenter presenter;
        private bool isLoad;
        public ExamUC()
        {
            InitializeComponent();
            isLoad = false;
        }

        private void ExamUC_Load(object sender, EventArgs e)
        {
            //presenter = new ExamsPresenter(this);
            isLoad = true;
            UC_Load?.Invoke();
        }

        public EducationalInstitution CurrentEducationalInstitution { get => cmbEducationalInstitutions.SelectedItem as EducationalInstitution; set => cmbEducationalInstitutions.SelectedItem = value; }
        public AcademicYear CurrentAcademicYear { get => cmblAcademicYears.SelectedItem as AcademicYear; set => cmblAcademicYears.SelectedItem = value; }
        public SchoolClass CurrentSchoolClass { get => cmbSchoolClasses.SelectedItem as SchoolClass; set => cmbSchoolClasses.SelectedItem = value; }
        public TypeOfAssessment CurrentTypeAssessment { get => cmbTypeAssessment.SelectedItem as TypeOfAssessment; set => cmbTypeAssessment.SelectedItem = value; }
        public object TableDataSource { get { return dataGrid.DataSource; } set { dataGrid.DataSource = null; dataGrid.DataSource = value; } }

        public object SelectTableRow
        {
            get
            {
                if (dataGrid.SelectedRows.Count == 0)
                    return null;
                else
                    return dataGrid.SelectedRows[0];
            }
        }

        public int SetCountTotal { set => lblCountTotal.Text = "Количество учащихся: " + value; }
        public int SetCountHighLevel { set => lblCountHighLevel.Text = "Высокий уровень:" + value; }
        public int SetCountSufficientLevel { set => lblCountSufficientLevel.Text = "Достаточный уровень:" + value; }
        public int SetCountMidleLevel { set => lblCountMidleLevel.Text = "Средний уровень:" + value; }
        public int SetCountSatisfactoryLevel { set => lblCountSatisfactoryLevel.Text = "Удовлетворительный уровень:" + value; }
        public int SetCountLowLevel { set => lblCountLowLevel.Text = "Низкий уровень:" + value; }
        public int SetCountFailedLevel { set => lblCountFailedLevel.Text = "Не аттестованы:" + value; }
        public double SetAverageMark { set => lblAverageMark.Text = "Средний бал:" + Math.Round(value,2); }
        public double SetQualityPercentage { set => lblQualityPercentage.Text = "Качество знаний, %:" + Math.Round(value, 2); }
        public string SetLevelEducationalActivity { set => lblLevelEducationalActivity.Text = "Уровень результатов учебной деятельности:" + value; }

        public event Action btnAdd_OnClick;
        public event Action btnEdit_OnClick;
        public event Action btnRemove_OnClick;
        public event Action btnUpdate_OnClick;
        public event Action btnExport_OnClick;
        public event Action btnImport_OnClick;
        public event Action CurrentEducationalInstitution_Changed;
        public event Action CurrentAcademicYear_Changed;
        public event Action CurrentSchoolClass_Changed;
        public event Action CurrentTypeAssessment_Changed;
        public event Action UC_Load;

        public void SetAcademicYears(object[] items)
        {
            cmblAcademicYears.Items.Clear();
            cmblAcademicYears.Items.AddRange(items);
            if(cmblAcademicYears.Items.Count > 0)
            {
                cmblAcademicYears.SelectedIndex = 0;
            }
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

        public void SetSchoolClasses(object[] items)
        {
            cmbSchoolClasses.Items.Clear();
            cmbSchoolClasses.Items.AddRange(items);
            if (cmbSchoolClasses.Items.Count > 0)
            {
                cmbSchoolClasses.SelectedIndex = 0;
            }
        }

        public void SetTypeOfAssessments(object[] items)
        {
            cmbTypeAssessment.Items.Clear();
            cmbTypeAssessment.Items.AddRange(items);
            if (cmbTypeAssessment.Items.Count > 0)
            {
                cmbTypeAssessment.SelectedIndex = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd_OnClick?.Invoke();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                btnEdit_OnClick?.Invoke();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            btnRemove_OnClick?.Invoke();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate_OnClick?.Invoke();
        }

        private void cmbEducationalInstitutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoad)
                return;

            CurrentEducationalInstitution_Changed?.Invoke();
        }

        private void cmblAcademicYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoad)
                return;

            CurrentAcademicYear_Changed?.Invoke();
        }

        private void cmbSchoolClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoad)
                return;

            CurrentSchoolClass_Changed?.Invoke();
        }

        private void cmbTypeAssessment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoad)
                return;

            CurrentTypeAssessment_Changed?.Invoke();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnExport_OnClick?.Invoke();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            btnImport_OnClick?.Invoke();
        }
    }
}
