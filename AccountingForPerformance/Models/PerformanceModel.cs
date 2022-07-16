using AccountingForPerformance.Entities;
using AccountingForPerformance.Interfaces;
using AccountingForPerformance.LogicalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForPerformance.Models
{
    public class PerformanceModel : IPerformancesModel
    {
        //private int maxId;
        private IDataContext db;
        public List<Performance> Performances { get; private set; }

        public PerformanceModel (IDataContext dataContext)
        {
            db = dataContext;
            Performances = new List<Performance>();
        }

        public void Load(EducationalInstitution educationalInstitution, AcademicYear academicYear, SchoolClass schoolClass, TypeOfAssessment typeAssessment = null)
        {
            Performances.Clear();
            if (educationalInstitution is null)
            {
                return;
            }

            if (academicYear is null)
            {
                return;
            }

            if (schoolClass is null)
            {
                return;
            }

            List<SchoolPerformance> performances = db.SchoolPerformances.Where(p => p.EducationalInstitutionId == educationalInstitution.Id
                                                                         && p.AcademicYearId == academicYear.Id
                                                                         && p.SchoolClassId == schoolClass.Id).OrderBy(p => p.SchoolSubjectId).ToList();
            if (typeAssessment != null)
            {
                performances = performances.Where(p => p.TypeOfAssessmentId == typeAssessment.Id).ToList();
            }

            Performances = SchoolPerfomanceToPerfomacne(performances);
        }
        public void Load(EducationalInstitution educationalInstitution, AcademicYear academicYear)
        {
            //Performances.Clear();
            if (educationalInstitution is null)
            {
                return;
            }

            if (academicYear is null)
            {
                return;
            }
            //Удалим сущесвтующий
            if (Performances.Where(p => p.EducationalInstitution.Id == educationalInstitution.Id
                                      && p.AcademicYear.Id == academicYear.Id).Count() > 0)
                Performances.RemoveAll(p => p.EducationalInstitution.Id == educationalInstitution.Id
                                         && p.AcademicYear.Id == academicYear.Id);
            
            //перезаполнит
            List<SchoolPerformance> performances = db.SchoolPerformances.Where(p => p.EducationalInstitutionId == educationalInstitution.Id
                                                                         && p.AcademicYearId == academicYear.Id
                                                                         ).OrderBy(p => p.SchoolSubjectId).ToList();

            Performances.AddRange(SchoolPerfomanceToPerfomacne(performances));
        }

        public void Load(TypeOfAssessment typeAssessment, AcademicYear academicYear, SchoolClass schoolClass = null)
        {
            Performances.Clear();
            //Performances.Clear();
            if (typeAssessment is null)
            {
                return;
            }

            if (academicYear is null)
            {
                return;
            }


            List<SchoolPerformance> performances = new List<SchoolPerformance>();
            if (schoolClass == null)
            {
                performances = db.SchoolPerformances.Where(p => p.TypeOfAssessment.Id == typeAssessment.Id
                                                                             && p.AcademicYearId == academicYear.Id
                                                                             ).OrderBy(p => p.SchoolSubjectId).ToList();
            }
            else
            {
                performances = db.SchoolPerformances.Where(p => p.TypeOfAssessment.Id == typeAssessment.Id
                                                                         && p.AcademicYearId == academicYear.Id
                                                                         && p.SchoolClassId == schoolClass.Id
                                                                         ).OrderBy(p => p.SchoolSubjectId).ToList();
            }

            Performances = SchoolPerfomanceToPerfomacne(performances);
        }


        private List<Performance> SchoolPerfomanceToPerfomacne(List<SchoolPerformance> schoolPerformances)
        {
            List<Performance> performances = new List<Performance>();

            var firstPerformance = schoolPerformances.FirstOrDefault();

            if (firstPerformance == null)
            {
                return new List<Performance>();
            }

            List<SchoolClass> classes = new List<SchoolClass>();
            List<SchoolSubject> subjects = new List<SchoolSubject>();
            List<EducationalInstitution> educationalInstitutions = new List<EducationalInstitution>();
            List<AcademicYear> years = new List<AcademicYear>();
            List<TypeOfAssessment> types = new List<TypeOfAssessment>();
            foreach (SchoolPerformance performance in schoolPerformances)
            {

                if (!classes.Any(c => c.Id == performance.SchoolClass.Id))
                    classes.Add(performance.SchoolClass);
                if (!subjects.Any(s => s.Id == performance.SchoolSubject.Id))
                    subjects.Add(performance.SchoolSubject);
                if (!years.Any(y => y.Id == performance.AcademicYear.Id))
                    years.Add(performance.AcademicYear);
                if (!types.Any(t => t.Id == performance.TypeOfAssessmentId))
                    types.Add(performance.TypeOfAssessment);
                if (!educationalInstitutions.Any(ei => ei.Id == performance.EducationalInstitution.Id))
                    educationalInstitutions.Add(performance.EducationalInstitution);
            }

            foreach (AcademicYear year in years)
            foreach (EducationalInstitution ei in educationalInstitutions)
            foreach (SchoolClass classSchool in classes)
            foreach (TypeOfAssessment type in types)
            foreach (SchoolSubject subject in subjects)
            {
                List<SchoolPerformance> tmpPerformances = schoolPerformances.Where(p => p.AcademicYearId == year.Id
                                                                                    && p.EducationalInstitutionId == ei.Id
                                                                                    && p.SchoolClassId == classSchool.Id
                                                                                    && p.TypeOfAssessmentId == type.Id
                                                                                    && p.SchoolSubjectId == subject.Id).ToList();
                if (tmpPerformances.Count == 0)
                    continue;

                Performance performance = new Performance();
                performance.AcademicYear = year;
                performance.EducationalInstitution = ei;
                performance.SchoolClass = classSchool;
                performance.SchoolSubject = subject;
                performance.TypeAssessment = type;

                foreach(SchoolPerformance schoolPerformance in tmpPerformances)
                {
                    performance.CountStudentsByAssessment.Add(new CountStudentsByAssessment(schoolPerformance.NumberOfStudents, schoolPerformance.LevelAssessment.Assessment));
                }

                performances.Add(performance);                                
            }

            return performances;
        }

        public void Remove(EducationalInstitution educationalInstitution, AcademicYear academicYear, SchoolClass schoolClass, SchoolSubject schoolSubject, TypeOfAssessment typeAssessment)
        {
            List<SchoolPerformance> performances = db.SchoolPerformances.Where(p => p.EducationalInstitutionId == educationalInstitution.Id
                                                                        && p.AcademicYearId == academicYear.Id
                                                                        && p.SchoolClassId == schoolClass.Id
                                                                        && p.SchoolSubjectId == schoolSubject.Id
                                                                        && p.TypeOfAssessmentId == typeAssessment.Id).ToList();
            foreach(SchoolPerformance performance in performances)
            {
                db.SchoolPerformances.Remove(performance);
            }

            db.SaveChanges();
        }

        public void RemoveToList(EducationalInstitution educationalInstitution, AcademicYear academicYear, TypeOfAssessment typeAssessment)
        {
            Performances.RemoveAll(p => p.EducationalInstitution.Id == educationalInstitution.Id
                                     && p.AcademicYear.Id == academicYear.Id
                                     && p.TypeAssessment.Id == typeAssessment.Id);
        }



        /// <summary>
        /// Всего сдавали экзамен
        /// </summary>
        public int CountTotal { get => Performances.Sum(c => c.CountTotal); }

        /// <summary>
        /// Высокий уровень
        /// </summary
        public int CountHighLevel { get => Performances.Sum(c => c.CountHighLevel); }
        /// <summary>
        /// Достаточный уровень
        /// </summary>
        public int CountSufficientLevel { get => Performances.Sum(c => c.CountSufficientLevel); }
        /// </summary>
        ///Средний уровень 
        /// <summary>
        public int CountMidleLevel { get => Performances.Sum(c => c.CountMidleLevel); }

        /// <summary>
        /// Удовлетворительный уровень
        /// </summary>
        public int CountSatisfactoryLevel { get => Performances.Sum(c => c.CountSatisfactoryLevel); }
        /// <summary>
        /// Низкий уровень
        /// </summary>
        public int CountLowLevel { get => Performances.Sum(c => c.CountLowLevel); }
        /// <summary>
        /// Не сдали экзамен
        /// </summary>
        public int CountFailedLevel { get => Performances.Sum(c => c.CountFailedLevel); }

        /// <summary>
        /// Средний бал
        /// </summary>
        public double AverageMark
        {
            get
            {
                double sumAssessmentStudents = Performances.Sum(p => p.AverageMark);

                return sumAssessmentStudents / Performances.Count;
            }
        }

        /// <summary>
        /// Качество знаний(10-7 баллов), %
        /// </summary>
        public double QualityPercentage
        {
            get
            {
                double sumAssessmentStudents = Performances.Sum(p => p.QualityPercentage);

                return sumAssessmentStudents / Performances.Count;
            }
        }


        /// <summary>
        /// Уровень результатов учебной деятельности
        /// </summary>
        public string LevelEducationalActivity
        {
            get
            {
                if (CountTotal == 0)
                    return "";
                if (CountFailedLevel == 0 && (double)CountHighLevel / CountTotal * 100 >= 50)
                    return "Высокий";
                if ((CountTotal - CountFailedLevel) / (double)CountTotal * 100 >= 95 && (CountHighLevel + CountSufficientLevel) / (float)CountTotal * 100 >= 60)
                    return "Достаточный";
                if ((CountTotal - CountFailedLevel) / (double)CountTotal * 100 >= 90 && (CountHighLevel + CountSufficientLevel + CountMidleLevel) / (float)CountTotal * 100 >= 70)
                    return "Средний";
                if ((CountTotal - CountFailedLevel) / (double)CountTotal * 100 >= 90 && (CountHighLevel + CountSufficientLevel + CountMidleLevel + CountSatisfactoryLevel) / (float)CountTotal * 100 >= 85)
                    return "Удовлетворительный";

                return "Низкий";
            }
        }
    }
}
