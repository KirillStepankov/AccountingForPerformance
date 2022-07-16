using AccountingForPerformance.Entities;
using System;

namespace AccountingForPerformance.Interfaces
{
    public interface IExamsView
    {
        //события редактиррования данных
        event Action UC_Load;
        event Action btnAdd_OnClick;
        event Action btnEdit_OnClick;
        event Action btnRemove_OnClick;
        event Action btnUpdate_OnClick;
        event Action btnExport_OnClick;
        event Action btnImport_OnClick;

        //события отбора данных
        event Action CurrentEducationalInstitution_Changed;
        event Action CurrentAcademicYear_Changed;
        event Action CurrentSchoolClass_Changed;
        event Action CurrentTypeAssessment_Changed;

        EducationalInstitution CurrentEducationalInstitution { get; set; }
        AcademicYear CurrentAcademicYear { get; set; }
        SchoolClass CurrentSchoolClass { get; set; }
        TypeOfAssessment CurrentTypeAssessment { get; set; }

        object TableDataSource { get; set; }  
        object SelectTableRow { get; }

        #region Итоги
        /// <summary>
        /// Всего сдавали экзамен
        /// </summary>
        int SetCountTotal { set; }

        /// <summary>
        /// Высокий уровень
        /// </summary
        int SetCountHighLevel { set; }
        /// <summary>
        /// Достаточный уровень
        /// </summary>
        int SetCountSufficientLevel { set; }
        /// </summary>
        ///Средний уровень 
        /// <summary>
        int SetCountMidleLevel { set; }

        /// <summary>
        /// Удовлетворительный уровень
        /// </summary>
        int SetCountSatisfactoryLevel { set; }
        /// <summary>
        /// Низкий уровень
        /// </summary>
        int SetCountLowLevel { set; }
        /// <summary>
        /// Не сдали экзамен
        /// </summary>
        int SetCountFailedLevel { set; }

        /// <summary>
        /// Средний бал
        /// </summary>
        double SetAverageMark { set; }

        /// <summary>
        /// Качество знаний(10-7 баллов), %
        /// </summary>
        double SetQualityPercentage { set; }

        /// <summary>
        /// Уровень результатов учебной деятельности
        /// </summary>
        string SetLevelEducationalActivity { set; }
        #endregion

        void SetEducationalInstitutions(object[] items);
        void SetAcademicYears(object[] items);
        void SetSchoolClasses(object[] items);
        void SetTypeOfAssessments(object[] items);
    }
}
