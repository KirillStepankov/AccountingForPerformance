using AccountingForPerformance.Data;
using AccountingForPerformance.Entities;
using AccountingForPerformance.Interfaces;
using AccountingForPerformance.LogicalEntities;
using AccountingForPerformance.Models;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace AccountingForPerformance.Presenters
{
    public class QuarterChartPresenter
    {
        private IDataContext db;
        private IPerformancesModel model;
        private IQuarterChartView view;

        public QuarterChartPresenter(IQuarterChartView chartView)
        {
            view = chartView;
            db = SingletonDataContext.GetInstance.DataContext;
            model = new PerformanceModel(db);

            ViewAddEvents();
            FillViewComboBox();
        }

        #region ViewEvents
        private void ViewAddEvents()
        {
            view.btnCreate_OnClick += View_btnCreate_OnClick;
        }

        private void View_btnCreate_OnClick()
        {
            model.Load (view.CurrentEducationalInstitution, view.CurrentAcademicYear, view.CurrentSchoolClass, null);
            List<Performance> performances = model.Performances;


            List<TypeOfAssessment> typeAssessments = new List<TypeOfAssessment>();
            foreach (Performance performance in performances)
            {
                if (!typeAssessments.Any(t => t.Id == performance.TypeAssessment.Id))
                    typeAssessments.Add(performance.TypeAssessment);
            }
            typeAssessments.OrderBy(t => t.Id);
            view.Chart.ChartAreas.Clear();
            view.Chart.Series.Clear();
            view.Chart.Legends.Clear();
            view.Chart.Titles.Clear();

            ChartArea qualityArea = new ChartArea("Качество");
            Legend qualityLegend = new Legend("qualityALegend");
            qualityLegend.LegendStyle = LegendStyle.Column;
            qualityLegend.Title = "По среднему балу"; //qualityTitle.Name;
            Legend averageLegend = new Legend("averageALegend");
            averageLegend.LegendStyle = LegendStyle.Column;
            averageLegend.Title = "Средний бал";// averageTitle.Name;

            view.Chart.Legends.Add(averageLegend);
            //view.Chart.Titles.Add(averageTitle);
            view.Chart.Legends.Add(qualityLegend);
            view.Chart.ChartAreas.Add(qualityArea);
            //view.ChartQuality.Titles.Add(qualityTitle);
            foreach (TypeOfAssessment typeAssessment in typeAssessments)
            {
                Series qualitySeries = new Series(typeAssessment.Name + "quality");
                double quality = performances.Where(p => p.TypeAssessment.Id == typeAssessment.Id).Sum(p => p.AverageMark) / performances.Where(p => p.TypeAssessment.Id == typeAssessment.Id).Count();
                qualitySeries.Points.AddY(quality);
                qualitySeries.ToolTip = quality.ToString();
                qualitySeries.ChartArea = qualityArea.Name;
                qualitySeries.Legend = qualityLegend.Name;
                qualitySeries.LegendText = typeAssessment.Name;
                qualitySeries.LegendToolTip = typeAssessment.Name;
                view.Chart.Series.Add(qualitySeries);
            }
            
            
        }
        #endregion

        private void FillViewComboBox()
        {
            view.SetAcademicYears(db.AcademicYears.OrderByDescending(ay => ay.Name).ToArray());
            view.SetEducationalInstitution(db.EducationalInstitutions.OrderBy(t=>t.Id).ToArray());
            view.SetSchoolClasses(db.SchoolClasses.OrderBy(t => t.Name).ToArray());
        }
    }
}
