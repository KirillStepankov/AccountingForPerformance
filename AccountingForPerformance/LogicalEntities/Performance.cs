using AccountingForPerformance.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AccountingForPerformance.LogicalEntities
{
    public class Performance: IPerformance, IPerformanceForReport, IPerformanceReportFilter
    {

        public Performance()
        {
            CountStudentsByAssessment = new List<CountStudentsByAssessment>();
        }

        [Browsable(false)]
        public List<CountStudentsByAssessment> CountStudentsByAssessment { get; set; }
        
        [Browsable(false)]
        [DisplayName("Учебное год")]
        public AcademicYear AcademicYear { get; set; }
        
        [Browsable(false)]
        [DisplayName("Учебное заведение")]
        public EducationalInstitution EducationalInstitution { get; set; }

        [DisplayName("Учебный предмет")]
        public SchoolSubject SchoolSubject { get; set; }

        [DisplayName("Класс")]
        public SchoolClass SchoolClass { get; set; }

        [DisplayName("Всего сдавали экзамен")]
        [DefaultValue(0)]
        public int CountTotal { get => CountStudentsByAssessment.Sum(c => c.CountStudents); }

        [DisplayName("Высокий уровень")]
        [DefaultValue(0)]
        public int CountHighLevel { get => CountStudentsByAssessment.Where(c => c.Assessment == 10 || c.Assessment == 9).Sum(c => c.CountStudents); }
        [DisplayName("Достаточный уровень")]
        [DefaultValue(0)]
        public int CountSufficientLevel { get => CountStudentsByAssessment.Where(c => c.Assessment == 7 || c.Assessment == 8).Sum(c => c.CountStudents); }
        [DisplayName("Средний уровень")]
        [DefaultValue(0)]
        public int CountMidleLevel { get => CountStudentsByAssessment.Where(c => c.Assessment == 5 || c.Assessment == 6).Sum(c => c.CountStudents); }
        [DisplayName("Удовлетворительный уровень")]
        [DefaultValue(0)]
        public int CountSatisfactoryLevel { get => CountStudentsByAssessment.Where(c => c.Assessment == 3 || c.Assessment == 4).Sum(c => c.CountStudents); }
        [DisplayName("Низкий уровень")]
        [DefaultValue(0)]
        public int CountLowLevel { get => CountStudentsByAssessment.Where(c => c.Assessment == 1 || c.Assessment == 2).Sum(c => c.CountStudents); }
        [DisplayName("Не сдали экзамен")]
        [DefaultValue(0)]
        public int CountFailedLevel { get => CountStudentsByAssessment.Where(c => c.Assessment == 0).Sum(c => c.CountStudents); }
        
        [DisplayName("Средний бал")]
        [DefaultValue(0)]
        public double AverageMark
        {
            get
            {
                double sumAssessmentStudents = 0;
                int countTotal = 0;
                foreach(CountStudentsByAssessment ca in CountStudentsByAssessment)
                {
                    sumAssessmentStudents += ca.Assessment * ca.CountStudents;
                    countTotal += ca.CountStudents;
                }

                if (countTotal == 0)
                    return 0;
                return Math.Round(sumAssessmentStudents / (countTotal - CountStudentsByAssessment.Where(ca => ca.Assessment == 0).Sum(ca => ca.Assessment)), 2);
            }
        }

        [DisplayName("Качество знаний(10-7 баллов), %")]
        [DefaultValue(0)]
        public double QualityPercentage
        {
            get
            {
                if (CountTotal == 0)
                    return 0;

                double sumAssessmentStudents = CountStudentsByAssessment.Where(ca => ca.Assessment <=10 && ca.Assessment >= 7).Sum(ca => ca.CountStudents);

                return Math.Round(sumAssessmentStudents / CountTotal *100,2);
            }
        }

        [DisplayName("Уровень результатов учебной деятельности")]
        [DefaultValue(0)]
        public string LevelEducationalActivity
        {
            get
            {
                if (CountTotal == 0)
                    return "";
                if (CountFailedLevel == 0 && (double)CountHighLevel / CountTotal * 100 >= 50)
                    return "Высокий";
                if ((CountTotal - CountFailedLevel) / (double)CountTotal * 100 >=95  && (CountHighLevel + CountSufficientLevel)/ (float)CountTotal * 100 >= 60)
                    return "Достаточный";
                if ((CountTotal - CountFailedLevel) / (double)CountTotal * 100 >= 90 && (CountHighLevel + CountSufficientLevel + CountMidleLevel) / (float)CountTotal * 100 >= 70)
                    return "Средний";
                if ((CountTotal - CountFailedLevel) / (double)CountTotal * 100 >= 90 && (CountHighLevel + CountSufficientLevel + CountMidleLevel + CountSatisfactoryLevel) / (float)CountTotal * 100 >= 85)
                    return "Удовлетворительный";
               
                return "Низкий";
            }
        }

        public TypeOfAssessment TypeAssessment { get; set; }

        public double GetPercentageOfTotal(int countToLevel)
        {
            return countToLevel / (double)CountTotal * 100;
        }

        
        public bool Equals(IPerformanceReportFilter other)
        {
            if (EducationalInstitution.Id == other.EducationalInstitution.Id
                && AcademicYear.Id == other.AcademicYear.Id
                && TypeAssessment.Id == other.TypeAssessment.Id)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            //Calculate the hash code for the product.
            return EducationalInstitution.Id.GetHashCode() ^ AcademicYear.Id.GetHashCode() ^ TypeAssessment.Id.GetHashCode();
        }

        public bool Equals(IPerformanceForReport other)
        {
            if (EducationalInstitution.Id == other.EducationalInstitution.Id
                && AcademicYear.Id == other.AcademicYear.Id)
                return true;
            return false;
        }
    }
}
