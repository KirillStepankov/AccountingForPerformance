using AccountingForPerformance.Entities;
using AccountingForPerformance.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingForPerformance.Views
{
    public partial class PerfomanceWork : Form
    {
        private bool isAdded;
        private IDataContext db;

        private NumericUpDown[] numericUps;
        public PerfomanceWork(IDataContext dataContext, bool IsAdded = true)
        {
            InitializeComponent();

            db = dataContext;
            isAdded = IsAdded;
            if(isAdded)
            {
                lblTitle.Text += ": Добавление";
            }
            else
            {
                lblTitle.Text += ": Редактирование";
                btnOk.Text = "Сохранить";
                cmbAcademicYears.Enabled = false;
                cmbEducationalInstitutions.Enabled = false;
                cmbSchoolClasses.Enabled = false;
                cmbSchoolSubject.Enabled = false;
                cmbTypeAssessment.Enabled = false;
            }


            numericUps = new NumericUpDown[11];
            numericUps[0] = num0;
            numericUps[1] = num1;
            numericUps[2] = num2;
            numericUps[3] = num3;
            numericUps[4] = num4;
            numericUps[5] = num5;
            numericUps[6] = num6;
            numericUps[7] = num7;
            numericUps[8] = num8;
            numericUps[9] = num9;
            numericUps[10] = num10;

            cmbEducationalInstitutions.Items.AddRange(db.EducationalInstitutions.ToArray());
            cmbSchoolSubject.Items.AddRange(db.SchoolSubjects.ToArray());
            cmbAcademicYears.Items.AddRange(db.AcademicYears.ToArray());
            cmbSchoolClasses.Items.AddRange(db.SchoolClasses.ToArray());
            cmbTypeAssessment.Items.AddRange(db.TypeOfAssessments.ToArray());
        }

        private List<SchoolPerformance> GetPerformancesFromDB()
        {
            List<SchoolPerformance> performancesFromDB = db.SchoolPerformances.Local.Where(p => p.AcademicYearId == ((AcademicYear)cmbAcademicYears.SelectedItem).Id
                                                                 && p.EducationalInstitutionId == (cmbEducationalInstitutions.SelectedItem as EducationalInstitution).Id
                                                                 && p.SchoolClassId == (cmbSchoolClasses.SelectedItem as SchoolClass).Id
                                                                 && p.SchoolSubjectId == (cmbSchoolSubject.SelectedItem as SchoolSubject).Id
                                                                 && p.TypeOfAssessmentId == (cmbTypeAssessment.SelectedItem as TypeOfAssessment).Id).ToList();

            return performancesFromDB;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(cmbSchoolSubject.SelectedItem == null)
            {
                MessageBox.Show("Выберите учебный предмет!");
                return;
            }
            if (cmbSchoolClasses.SelectedItem == null)
            {
                MessageBox.Show("Выберите учебный класс!");
                return;
            }
            if (cmbAcademicYears.SelectedItem == null)
            {
                MessageBox.Show("Выберите учебный год!");
                return;
            }
            if (cmbEducationalInstitutions.SelectedItem == null)
            {
                MessageBox.Show("Выберите учебное заведение!");
                return;
            }
            if (cmbTypeAssessment.SelectedItem == null)
            {
                MessageBox.Show("Выберите период!");
                return;
            }
            if (isAdded)
            {
                Add();
            }
            else
            {
                Edit();
            }
        }

        private void Add()
        {
            List<SchoolPerformance> performancesFromDB = GetPerformancesFromDB();

            if(performancesFromDB.Count != 0)
            {
                if(MessageBox.Show("Запись с указаными уникальными параметрами уже сущесвтует. Желаете ее заменить?", "Запись", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.No)
                {
                    return;
                }
                db.SchoolPerformances.RemoveRange(performancesFromDB);
            }

            for (int i = 0; i <= 10; i++)
            {
                SchoolPerformance performance = new SchoolPerformance
                {
                    EducationalInstitutionId = (cmbEducationalInstitutions.SelectedItem as EducationalInstitution).Id,
                    SchoolSubjectId = (cmbSchoolSubject.SelectedItem as SchoolSubject).Id,
                    NumberOfStudents = Convert.ToInt32(numericUps[i].Value),
                    LevelAssessmentId = db.LevelAssessments.Where(a => a.Assessment == i).FirstOrDefault().Id,
                    TypeOfAssessmentId = (cmbTypeAssessment.SelectedItem as TypeOfAssessment).Id,
                    AcademicYearId = (cmbAcademicYears.SelectedItem as AcademicYear).Id,
                    SchoolClassId = (cmbSchoolClasses.SelectedItem as SchoolClass).Id
                };
                AddRecord(performance);
            }

            this.Close();
        }

        private void AddRecord(SchoolPerformance performance)
        {
            db.SchoolPerformances.Add(performance);
            db.SaveChanges();
        }

        private void Edit()
        {
            List<SchoolPerformance> performancesFromDB = GetPerformancesFromDB();

            if (performancesFromDB.Count != 0)
            {
                db.SchoolPerformances.RemoveRange(performancesFromDB);
            }

            for (int i = 0; i <= 10; i++)
            {
                AddRecord(new SchoolPerformance
                {
                    EducationalInstitutionId = (cmbEducationalInstitutions.SelectedItem as EducationalInstitution).Id,
                    SchoolSubjectId = (cmbSchoolSubject.SelectedItem as SchoolSubject).Id,
                    NumberOfStudents = Convert.ToInt32(numericUps[i].Value),
                    LevelAssessmentId = db.LevelAssessments.Where(a => a.Assessment == i).FirstOrDefault().Id,
                    TypeOfAssessmentId = (cmbTypeAssessment.SelectedItem as TypeOfAssessment).Id,
                    AcademicYearId = (cmbAcademicYears.SelectedItem as AcademicYear).Id,
                    SchoolClassId = (cmbSchoolClasses.SelectedItem as SchoolClass).Id
                });
            }

            this.Close();
        }

        private void PerfomanceWork_Load(object sender, EventArgs e)
        {
            if (!isAdded)
            {
                List<SchoolPerformance> performancesFromDB = GetPerformancesFromDB();

                for (int i = 0; i <= 10; i++)
                {
                    int? countStudents = performancesFromDB.Where(p => p.LevelAssessment.Assessment == i).FirstOrDefault()?.NumberOfStudents;
                    numericUps[i].Value = countStudents ?? 0;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void num10_ValueChanged(object sender, EventArgs e)
        {
            lblTotal.Text = (num0.Value + num1.Value + num2.Value + num3.Value + num4.Value + num5.Value + num6.Value + num7.Value + num8.Value + num9.Value + num10.Value).ToString();
        }
    }
}
