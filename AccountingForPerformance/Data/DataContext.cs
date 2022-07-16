using AccountingForPerformance.Entities;
using AccountingForPerformance.Interfaces;
using System.Data.Entity;

namespace AccountingForPerformance.Data
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(string connectionString = "DefaultConnection") : base(connectionString) { }

        public DbSet<AcademicPerformance> AcademicPerformances { get; set; }
        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<EducationalInstitution> EducationalInstitutions { get; set; }
        public DbSet<LevelAssessment> LevelAssessments { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<SchoolPerformance> SchoolPerformances { get; set; }
        public DbSet<SchoolSubject> SchoolSubjects { get; set; }
        public DbSet<TypeOfAssessment> TypeOfAssessments { get; set; }
    }
}
