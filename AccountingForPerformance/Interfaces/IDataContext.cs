using AccountingForPerformance.Entities;
using System;
using System.Data.Entity;

namespace AccountingForPerformance.Interfaces
{
    public interface IDataContext
    {
        DbSet<AcademicPerformance> AcademicPerformances { get; set; }
        DbSet<AcademicYear> AcademicYears { get; set; }
        DbSet<EducationalInstitution> EducationalInstitutions { get; set; }
        DbSet<LevelAssessment> LevelAssessments { get; set; }
        DbSet<SchoolClass> SchoolClasses { get; set; }
        DbSet<SchoolPerformance> SchoolPerformances { get; set; }
        DbSet<SchoolSubject> SchoolSubjects { get; set; }
        DbSet<TypeOfAssessment> TypeOfAssessments { get; set; }

        int SaveChanges();
    }
}
