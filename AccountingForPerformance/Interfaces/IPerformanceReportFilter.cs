using AccountingForPerformance.Entities;
using System;
using System.ComponentModel;

namespace AccountingForPerformance.LogicalEntities
{
    public interface IPerformanceReportFilter : IEquatable<IPerformanceReportFilter>
    {
        [DisplayName("Учебное заведение")]
        EducationalInstitution EducationalInstitution { get; set; }
        
        [DisplayName("Учебный год")]
        AcademicYear AcademicYear { get; set; }

        [DisplayName("Период")]
        TypeOfAssessment TypeAssessment { get; set; }
    }
}
