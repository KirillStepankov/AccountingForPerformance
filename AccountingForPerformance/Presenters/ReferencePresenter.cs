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
    public class ReferencePresenter
    {
        private IDataContext db;
        private IReferencesView view;

        public ReferencePresenter(IReferencesView referenceView)
        {
            view = referenceView;
            db = SingletonDataContext.GetInstance.DataContext;

            ViewAddEvents();
            FillTable(db.EducationalInstitutions.ToList());   // заполним выбранную(первую) таблицу
        }
        
        public void FillTable(object data)
        {
            view.DataSource = data;
        }

        #region ViewEvents
        private void ViewAddEvents()
        {
            view.btnAddAY_OnClick += View_btnAddAY_OnClick;
            view.btnAddEI_OnClick += View_btnAddEI_OnClick;
            view.btnEditEI_OnClick += View_btnEditEI_OnClick;
            view.btnRemoveEI_OnClick += View_btnRemoveEI_OnClick;
            view.CurrentTab_Changed += View_CurrentTab_Changed;
        }

        private void View_CurrentTab_Changed()
        {
            switch(view.SelectIndexTab)
            {
                case 0:
                    FillTable(db.EducationalInstitutions.ToList());
                    break;
                case 1:
                    FillTable(db.AcademicYears.ToList());
                    break;
                case 2:
                    FillTable(db.SchoolSubjects.ToList());
                    break;
                case 3:
                    FillTable(db.SchoolClasses.ToList());
                    break;
                case 4:
                    FillTable(db.LevelAssessments.ToList());
                    break;
            }
        }

        private void View_btnRemoveEI_OnClick()
        {
            if (view.SelectRow == null)
                return;

            string nameEI = (view.SelectRow as DataGridViewRow).Cells["Name"].Value.ToString();
            EducationalInstitution educationalInstitution = db.EducationalInstitutions
                .Where(y => y.Name.Equals(nameEI)).FirstOrDefault();
            db.EducationalInstitutions.Remove(educationalInstitution);
            db.SaveChanges();

        }

        private void View_btnEditEI_OnClick()
        {
            EIWork work = new EIWork(db, (view.SelectRow as DataGridViewRow).Cells["Name"].Value.ToString(),true);
            work.txtEI.Text = (view.SelectRow as DataGridViewRow).Cells["Name"].Value.ToString();
            work.ShowDialog();
        }

        private void View_btnAddEI_OnClick()
        {
            EIWork work = new EIWork(db);
            work.ShowDialog();
        }

        private void View_btnAddAY_OnClick()
        {
            int currentYear= DateTime.Now.Year;
            char separator = '-';
            string currentAcademicYear = "";
            if (DateTime.Now.Month < 9 && DateTime.Now.Month >= 1)
            {
                currentAcademicYear = string.Format($"{(currentYear - 1)}{separator}{currentYear}");
            }
            else
            {
                currentAcademicYear = string.Format($"{(currentYear)}{separator}{currentYear+1}");
            }

            if (db.AcademicYears.Where(y => y.Name.Equals(currentAcademicYear)).Count() > 0)
                return;
            db.AcademicYears.Add(new AcademicYear { Name = currentAcademicYear });
            db.SaveChanges();

        }
        #endregion
    }
}
