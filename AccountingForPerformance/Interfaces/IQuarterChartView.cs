using AccountingForPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace AccountingForPerformance.Interfaces
{
    public interface IQuarterChartView
    {
        event Action btnCreate_OnClick;

        AcademicYear CurrentAcademicYear { get; }
        EducationalInstitution CurrentEducationalInstitution { get; }
        SchoolClass CurrentSchoolClass { get; }

        void SetAcademicYears(object[] items);
        void SetEducationalInstitution(object[] items);
        void SetSchoolClasses(object[] items);

        Chart Chart{ get; }

    }
}
