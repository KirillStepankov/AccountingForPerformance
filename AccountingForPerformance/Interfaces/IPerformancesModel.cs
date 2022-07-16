using AccountingForPerformance.Entities;
using AccountingForPerformance.LogicalEntities;
using System.Collections.Generic;

namespace AccountingForPerformance.Interfaces
{
    public interface IPerformancesModel
    {
        List<Performance> Performances { get; }

        /// <summary>
        /// Всего сдавали экзамен
        /// </summary>
        int CountTotal { get; }

        /// <summary>
        /// Высокий уровень
        /// </summary
        int CountHighLevel { get; }
        /// <summary>
        /// Достаточный уровень
        /// </summary>
        int CountSufficientLevel { get; }
        /// </summary>
        ///Средний уровень 
        /// <summary>
        int CountMidleLevel { get; }

        /// <summary>
        /// Удовлетворительный уровень
        /// </summary>
        int CountSatisfactoryLevel { get; }
        /// <summary>
        /// Низкий уровень
        /// </summary>
        int CountLowLevel { get; }
        /// <summary>
        /// Не сдали экзамен
        /// </summary>
        int CountFailedLevel { get; }

        /// <summary>
        /// Средний бал
        /// </summary>
        double AverageMark { get; }

        /// <summary>
        /// Качество знаний(10-7 баллов), %
        /// </summary>
        double QualityPercentage { get; }

        string LevelEducationalActivity { get; }


        void Load(EducationalInstitution educationalInstitution, AcademicYear academicYear, SchoolClass schoolClass, TypeOfAssessment typeAssessment);
        void Load(EducationalInstitution educationalInstitution, AcademicYear academicYear);
        void Load(TypeOfAssessment educationalInstitution, AcademicYear academicYear, SchoolClass schoolClass = null);
        void Remove(EducationalInstitution educationalInstitution, AcademicYear academicYear, SchoolClass schoolClass, SchoolSubject schoolSubject, TypeOfAssessment typeAssessment);
        void RemoveToList(EducationalInstitution educationalInstitution, AcademicYear academicYear, TypeOfAssessment typeAssessment);
    }
}
