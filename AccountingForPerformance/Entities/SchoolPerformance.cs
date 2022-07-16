using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForPerformance.Entities
{
    [Serializable]
    public class SchoolPerformance
    {
        public int Id { get; set; }
        public int EducationalInstitutionId { get; set; }
        public virtual EducationalInstitution EducationalInstitution { get; set; }
        public int SchoolSubjectId { get; set; }
        public virtual SchoolSubject SchoolSubject { get; set; }
        public int NumberOfStudents { get; set; }
        public int LevelAssessmentId { get; set; }
        public virtual LevelAssessment LevelAssessment { get; set; }
        public int TypeOfAssessmentId { get; set; }
        public virtual TypeOfAssessment TypeOfAssessment { get; set; }
        public int AcademicYearId { get; set; }
        public virtual AcademicYear AcademicYear { get; set; }
        public int SchoolClassId { get; set; }
        public virtual SchoolClass SchoolClass { get; set; }
    }
}
