using AccountingForPerformance.Data;
using AccountingForPerformance.Entities;
using AccountingForPerformance.Interfaces;
using AccountingForPerformance.LogicalEntities;
using AccountingForPerformance.Models;
using AccountingForPerformance.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingForPerformance.Presenters
{
    public class PerformancePresenter
    {
        private IDataContext db;
        private IPerformancesModel model;
        private IExamsView view;
        private ISerialize serialize;

        public PerformancePresenter(IExamsView examsVeiw)
        {
            view = examsVeiw;
            db = SingletonDataContext.GetInstance.DataContext;

            model = new PerformanceModel(db);
            serialize = new Serialize();

            ViewAddEvents();
            FillViewComboBox();
        }

        #region ViewEvents
        private void ViewAddEvents()
        {
            view.btnAdd_OnClick += View_btnAdd_OnClick;
            view.btnEdit_OnClick += View_btnEdit_OnClick;
            view.btnRemove_OnClick += View_btnRemove_OnClick;
            view.btnUpdate_OnClick += View_btnUpdate_OnClick;
            view.CurrentAcademicYear_Changed += View_CurrentAcademicYear_Changed;
            view.CurrentEducationalInstitution_Changed += View_CurrentEducationalInstitution_Changed;
            view.CurrentSchoolClass_Changed += View_CurrentSchoolClass_Changed;
            view.CurrentTypeAssessment_Changed += View_CurrentTypeAssessment_Changed;
            view.UC_Load += View_UC_Load;
            view.btnImport_OnClick += View_btnImport_OnClick;
            view.btnExport_OnClick += View_btnExport_OnClick;
        }

        private void View_btnExport_OnClick()
        {
            List<SchoolPerformance> performances = db.SchoolPerformances.Where(p => p.EducationalInstitutionId == view.CurrentEducationalInstitution.Id
                                                                         && p.AcademicYearId == view.CurrentAcademicYear.Id
                                                                         && p.SchoolClassId == view.CurrentSchoolClass.Id
                                                                         && p.TypeOfAssessmentId == view.CurrentTypeAssessment.Id).OrderBy(p => p.SchoolSubjectId).ToList();

            serialize.Serializable(performances);
        }

        private void View_btnImport_OnClick()
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                List<SchoolPerformance> performances = serialize.Deserializable(opf.FileName);

                foreach(SchoolPerformance performance in performances)
                {
                    int? idEI = db.EducationalInstitutions.Where(i => i.Name.Equals(performance.EducationalInstitution.Name)).FirstOrDefault()?.Id;
                    if(idEI == null)
                    {
                        EducationalInstitution newEI =  db.EducationalInstitutions.Add(new EducationalInstitution { Name = performance.EducationalInstitution.Name });
                        idEI = newEI?.Id ?? throw new ArgumentNullException(nameof(idEI));
                    }

                    int? idsubject = db.SchoolSubjects.Where(i => i.Name.Equals(performance.SchoolSubject.Name)).FirstOrDefault()?.Id;
                    if (idsubject == null)
                    {
                        SchoolSubject newSubject = db.SchoolSubjects.Add(new SchoolSubject { Name = performance.SchoolSubject.Name });
                        idsubject = newSubject?.Id ?? throw new ArgumentNullException(nameof(idsubject));
                    }

                    int? idLevelAssessments = db.LevelAssessments.Where(i => i.Assessment.Equals(performance.LevelAssessment.Assessment)).FirstOrDefault()?.Id;
                    if (idLevelAssessments == null)
                    {
                        int? idlevelPerfomance = db.AcademicPerformances.Where(i => i.Name.Equals(performance.LevelAssessment.AcademicPerformance.Name)).FirstOrDefault()?.Id;
                        if (idlevelPerfomance == null)
                        {
                            AcademicPerformance newAP = db.AcademicPerformances.Add(new AcademicPerformance { Name = performance.LevelAssessment.AcademicPerformance.Name});
                            idlevelPerfomance = newAP?.Id ?? throw new ArgumentNullException(nameof(idlevelPerfomance));
                        }

                        LevelAssessment newlevel = db.LevelAssessments.Add(new LevelAssessment { Assessment = performance.LevelAssessment.Id, AcademicPerformanceId = (int)idlevelPerfomance});
                        idLevelAssessments = newlevel?.Id ?? throw new ArgumentNullException(nameof(idLevelAssessments));
                    }

                    int? idType = db.TypeOfAssessments.Where(i => i.Name.Equals(performance.TypeOfAssessment.Name)).FirstOrDefault()?.Id;
                    if (idType == null)
                    {
                        TypeOfAssessment newType = db.TypeOfAssessments.Add(new TypeOfAssessment { Name = performance.TypeOfAssessment.Name });
                        idType = newType?.Id ?? throw new ArgumentNullException(nameof(idType));
                    }

                    int? idYear = db.AcademicYears.Where(i => i.Name.Equals(performance.AcademicYear.Name)).FirstOrDefault()?.Id;
                    if (idYear == null)
                    {
                        AcademicYear newYear = db.AcademicYears.Add(new AcademicYear { Name = performance.AcademicYear.Name });
                        idYear = newYear?.Id ?? throw new ArgumentNullException(nameof(idYear));
                    }

                    int? idClass= db.SchoolClasses.Where(i => i.Name.Equals(performance.SchoolClass.Name)).FirstOrDefault()?.Id;
                    if (idClass == null)
                    {
                        SchoolClass newClass = db.SchoolClasses.Add(new SchoolClass { Name = performance.SchoolClass.Name });
                        idClass = newClass?.Id ?? throw new ArgumentNullException(nameof(newClass));
                    }

                    SchoolPerformance newPerformance = new SchoolPerformance
                    {
                        EducationalInstitutionId = (int)idEI,
                        SchoolSubjectId = (int)idsubject,
                        LevelAssessmentId = (int)idLevelAssessments,
                        TypeOfAssessmentId = (int)idType,
                        AcademicYearId = (int)idYear,
                        SchoolClassId = (int)idClass,
                        NumberOfStudents = performance.NumberOfStudents
                    };
                    db.SchoolPerformances.Add(newPerformance);
                    db.SaveChanges();
                }

                //db.SchoolPerformances.AddRange(performances); /// а если базы не совпадут????

            }
        }

        private void View_UC_Load()
        {
            FillTable();
        }

        private void View_CurrentTypeAssessment_Changed()
        {
            FillTable();
        }

        private void View_CurrentSchoolClass_Changed()
        {
            FillTable();
        }

        private void View_CurrentEducationalInstitution_Changed()
        {
            FillTable();
        }

        private void View_CurrentAcademicYear_Changed()
        {
            FillTable();
        }

        private void View_btnUpdate_OnClick()
        {
            FillViewComboBox();
            FillTable();
        }

        private void View_btnRemove_OnClick()
        {
            if (MessageBox.Show("Вы действительно желаете удалить выделенную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                List<SchoolPerformance> performancesFromDB = db.SchoolPerformances.Local.Where(p => p.AcademicYearId == view.CurrentAcademicYear.Id
                                                                 && p.EducationalInstitutionId == view.CurrentEducationalInstitution.Id
                                                                 && p.SchoolClassId == view.CurrentSchoolClass.Id
                                                                 && p.SchoolSubjectId == ((view.SelectTableRow as DataGridViewRow)?.Cells["SchoolSubject"].Value as SchoolSubject).Id
                                                                 ).ToList();
                db.SchoolPerformances.RemoveRange(performancesFromDB);
                db.SaveChanges();

                FillTable();
            }
        }

        private void View_btnEdit_OnClick()
        {
            PerfomanceWork pwForm = new PerfomanceWork(db, false);
            pwForm.cmbAcademicYears.SelectedItem = view.CurrentAcademicYear;
            pwForm.cmbEducationalInstitutions.SelectedItem = view.CurrentEducationalInstitution;
            pwForm.cmbSchoolClasses.SelectedItem = view.CurrentSchoolClass;
            pwForm.cmbSchoolSubject.SelectedItem = (view.SelectTableRow as System.Windows.Forms.DataGridViewRow)?.Cells["SchoolSubject"].Value as SchoolSubject;
            pwForm.cmbTypeAssessment.SelectedItem = view.CurrentTypeAssessment;
            pwForm.ShowDialog();
            
            FillTable();
        }

        private void View_btnAdd_OnClick()
        {
            PerfomanceWork pwForm = new PerfomanceWork(db, true);
            pwForm.cmbAcademicYears.SelectedItem = view.CurrentAcademicYear;
            pwForm.cmbEducationalInstitutions.SelectedItem = view.CurrentEducationalInstitution;
            pwForm.cmbSchoolClasses.SelectedItem = view.CurrentSchoolClass;
            pwForm.cmbSchoolSubject.SelectedIndex = (pwForm.cmbSchoolSubject.SelectedIndex > 0 ? 0 : -1);
            pwForm.cmbTypeAssessment.SelectedItem = view.CurrentTypeAssessment;
            pwForm.ShowDialog();

            FillTable();
        }
        #endregion

        private void FillViewComboBox()
        {
            view.SetAcademicYears(db.AcademicYears.OrderByDescending(ay => ay.Name).ToArray());
            view.SetEducationalInstitutions(db.EducationalInstitutions.ToArray());
            view.SetSchoolClasses(db.SchoolClasses.OrderBy(sc => sc.Id).ToArray());
            view.SetTypeOfAssessments(db.TypeOfAssessments.OrderBy(ta => ta.Name).ToArray());
        }
        private void FillTable()
        {
            model.Load(view.CurrentEducationalInstitution, view.CurrentAcademicYear, view.CurrentSchoolClass, view.CurrentTypeAssessment);
            view.TableDataSource = model.Performances.ToList<IPerformance>();

            view.SetCountTotal = model.CountTotal;
            view.SetCountHighLevel = model.CountHighLevel;
            view.SetCountSufficientLevel = model.CountSufficientLevel;
            view.SetCountMidleLevel = model.CountMidleLevel;
            view.SetCountSatisfactoryLevel = model.CountSatisfactoryLevel;
            view.SetCountLowLevel = model.CountLowLevel;
            view.SetCountFailedLevel = model.CountFailedLevel;
            view.SetAverageMark = model.AverageMark;
            view.SetQualityPercentage = model.QualityPercentage;
            view.SetLevelEducationalActivity = model.LevelEducationalActivity;
        }
    }
}
