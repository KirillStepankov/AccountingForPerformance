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
    public class ChartPresenter
    {
        private IDataContext db;
        private IPerformancesModel model;
        private IChartView view;

        public ChartPresenter(IChartView chartView)
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
            model.Load(view.CurrentTypeAssessment, view.CurrentAcademicYear, view.CurrentSchoolClass);
            List<Performance> performances = model.Performances;


            List<EducationalInstitution> educationalInstitutions = new List<EducationalInstitution>();
            foreach (Performance performance in performances)
            {
                if (!educationalInstitutions.Any(ei => ei.Id == performance.EducationalInstitution.Id))
                    educationalInstitutions.Add(performance.EducationalInstitution);
            }
            view.ChartAverage.ChartAreas.Clear();
            view.ChartAverage.Series.Clear();
            view.ChartAverage.Legends.Clear();
            view.ChartAverage.Titles.Clear();

            view.ChartQuality.ChartAreas.Clear();
            view.ChartQuality.Series.Clear();
            view.ChartQuality.Legends.Clear();
            view.ChartQuality.Titles.Clear();

            //Title qualityTitle = new Title("Качество успеваемости");
            //Title averageTitle = new Title("Средний бал");
            ChartArea qualityArea = new ChartArea("Качество");
            ChartArea averageArea = new ChartArea("Средний");
            Legend qualityLegend = new Legend("qualityALegend");
            qualityLegend.LegendStyle = LegendStyle.Column;
            qualityLegend.Title = "Качество успеваемости"; //qualityTitle.Name;
            Legend averageLegend = new Legend("averageALegend");
            averageLegend.LegendStyle = LegendStyle.Column;
            averageLegend.Title = "Средний бал";// averageTitle.Name;

            view.ChartAverage.Legends.Add(averageLegend);
            view.ChartAverage.ChartAreas.Add(averageArea);
            //view.Chart.Titles.Add(averageTitle);
            view.ChartQuality.Legends.Add(qualityLegend);
            view.ChartQuality.ChartAreas.Add(qualityArea);
            //view.ChartQuality.Titles.Add(qualityTitle);
            foreach (EducationalInstitution EI in educationalInstitutions)
            {
                Series qualitySeries = new Series(EI.Name + "quality");
                double quality = performances.Where(p => p.EducationalInstitution.Id == EI.Id).Sum(p => p.QualityPercentage) / performances.Where(p => p.EducationalInstitution.Id == EI.Id).Count();
                qualitySeries.Points.AddY(quality);
                qualitySeries.ToolTip = quality.ToString();
                qualitySeries.ChartArea = qualityArea.Name;
                qualitySeries.Legend = qualityLegend.Name;
                qualitySeries.LegendText = EI.Name;
                qualitySeries.LegendToolTip = EI.Name;
                view.ChartQuality.Series.Add(qualitySeries);

                Series averageSeries = new Series(EI.Name + "Average");
                double average = performances.Where(p => p.EducationalInstitution.Id == EI.Id).Sum(p => p.AverageMark) / performances.Where(p => p.EducationalInstitution.Id == EI.Id).Count();
                averageSeries.Points.AddY(average);
                averageSeries.ToolTip = average.ToString();
                averageSeries.ChartArea = averageArea.Name;
                averageSeries.Legend = averageLegend.Name;
                averageSeries.LegendText = EI.Name;
                averageSeries.LegendToolTip = EI.Name;
                view.ChartAverage.Series.Add(averageSeries);
            }
            
            
        }
        #endregion

        private void FillViewComboBox()
        {
            view.SetAcademicYears(db.AcademicYears.OrderByDescending(ay => ay.Name).ToArray());
            view.SetTypeAssessments(db.TypeOfAssessments.OrderBy(t=>t.Id).ToArray());
            view.SetSchoolClasses(db.SchoolClasses.OrderBy(t => t.Name).ToArray());
        }
    }
}
