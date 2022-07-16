using AccountingForPerformance.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AccountingForPerformance.LogicalEntities
{
    public interface IPerformance
    {

        [Browsable(false)]
        List<CountStudentsByAssessment> CountStudentsByAssessment { get; set; }

        [Browsable(false)]
        [DisplayName("Учебное год")]
        AcademicYear AcademicYear { get; set; }

        [Browsable(false)]
        [DisplayName("Учебное заведение")]
        EducationalInstitution EducationalInstitution { get; set; }
        [Browsable(false)]
        [DisplayName("Период")]
        TypeOfAssessment TypeAssessment { get; set; }

        [DisplayName("Учебный предмет")]
        SchoolSubject SchoolSubject { get; set; }

        [DisplayName("Всего сдавали экзамен")]
        [DefaultValue(0)]
        int CountTotal { get; }

        [DisplayName("Высокий уровень")]
        [DefaultValue(0)]
        int CountHighLevel { get; }
        [DisplayName("Достаточный уровень")]
        [DefaultValue(0)]
        int CountSufficientLevel { get; }
        [DisplayName("Средний уровень")]
        [DefaultValue(0)]
        int CountMidleLevel { get; }
        [DisplayName("Удовлетворительный уровень")]
        [DefaultValue(0)]
        int CountSatisfactoryLevel { get; }
        [DisplayName("Низкий уровень")]
        [DefaultValue(0)]
        int CountLowLevel { get; }
        [DisplayName("Не сдали экзамен")]
        [DefaultValue(0)]
        int CountFailedLevel { get; }

        [DisplayName("Средний бал")]
        [DefaultValue(0)]
        double AverageMark { get; }

        [DisplayName("Качество знаний(10-7 баллов), %")]
        [DefaultValue(0)]
        double QualityPercentage { get; }

        [DisplayName("Уровень результатов учебной деятельности")]
        [DefaultValue(0)]
        string LevelEducationalActivity { get; }

        double GetPercentageOfTotal(int countToLevel);
    }
}