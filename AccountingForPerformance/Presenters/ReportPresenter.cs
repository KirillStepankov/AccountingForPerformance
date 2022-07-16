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
    public class ReportPresenter
    {
        private IDataContext db;
        private IPerformancesModel model;
        private IReportView view;

        public ReportPresenter(IReportView reportView)
        {
            view = reportView;
            db = SingletonDataContext.GetInstance.DataContext;

            model = new PerformanceModel(db);

            ViewAddEvents();
            FillViewComboBox();
        }

        #region ViewEvents
        private void ViewAddEvents()
        {
            view.btnAdd_OnClick += View_btnAdd_OnClick;
            view.btnRemove_OnClick += View_btnRemove_OnClick;
            view.btnClear_OnClick += View_btnClear_OnClick;
            view.btnExport_OnClick += View_btnExport_OnClick;
            view.CurrentFilter_Changed += View_CurrentFilter_Changed;
        }

        private void View_CurrentFilter_Changed()
        {
            var selectFilterRow = (view.SelectFilterRow as DataGridViewRow);
            if (selectFilterRow == null)
                return;

            var academicYear = selectFilterRow.Cells["AcademicYear"].Value as AcademicYear;
            var educationalInstitution = selectFilterRow.Cells["EducationalInstitution"].Value as EducationalInstitution;
            var typeAssessment = selectFilterRow.Cells["TypeAssessment"].Value as TypeOfAssessment;

            view.PerfomanceDataSource = model.Performances.Where(p => p.EducationalInstitution.Id == educationalInstitution.Id
                                     && p.AcademicYear.Id == academicYear.Id
                                     && p.TypeAssessment.Id == typeAssessment.Id).ToList<IPerformanceForReport>();
        }

        private void View_btnExport_OnClick()
        {
            ExportExcel exportExcel = new ExportExcel();
            exportExcel.Export(model.Performances);
        }

        private void View_btnClear_OnClick()
        {
            model.Performances.Clear();
            view.FilterDataSource = null;
        }

        private void View_btnRemove_OnClick()
        {
            if (view.SelectFilterRow == null)
                return;

            var selectFilterRow = (view.SelectFilterRow as DataGridViewRow);
            var academicYear = selectFilterRow.Cells["AcademicYear"].Value as AcademicYear;
            var educationalInstitution = selectFilterRow.Cells["EducationalInstitution"].Value as EducationalInstitution;
            var typeAssessment = selectFilterRow.Cells["TypeAssessment"].Value as TypeOfAssessment;
            model.RemoveToList(educationalInstitution, academicYear, typeAssessment);
            
            view.FilterDataSource = model.Performances.ToList<IPerformanceReportFilter>().Distinct().ToList();
        }

        private void View_btnAdd_OnClick()
        {
            model.Load(view.CurrentEducationalInstitution, view.CurrentAcademicYear);
            view.FilterDataSource = model.Performances.ToList<IPerformanceReportFilter>().Distinct().ToList();
        }

        private void View_UC_Load()
        {
           
        }
        #endregion

        private void FillViewComboBox()
        {
            view.SetAcademicYears(db.AcademicYears.OrderByDescending(ay => ay.Name).ToArray());
            view.SetEducationalInstitutions(db.EducationalInstitutions.ToArray());
        }
    }
}
