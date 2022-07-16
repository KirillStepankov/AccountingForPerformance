using AccountingForPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace AccountingForPerformance.Interfaces
{
    public interface IChartView
    {
        event Action btnCreate_OnClick;

        AcademicYear CurrentAcademicYear { get; }
        TypeOfAssessment CurrentTypeAssessment { get; }
        SchoolClass CurrentSchoolClass { get; }

        void SetAcademicYears(object[] items);
        void SetTypeAssessments(object[] items);
        void SetSchoolClasses(object[] items);

        Chart ChartQuality { get; }
        Chart ChartAverage { get; }

    }
}
