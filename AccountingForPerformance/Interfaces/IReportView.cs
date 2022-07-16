using AccountingForPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForPerformance.Interfaces
{
    public interface IReportView
    {
        //события редактиррования данных
        event Action btnAdd_OnClick;
        event Action btnRemove_OnClick;
        event Action btnClear_OnClick;
        event Action btnExport_OnClick;
        event Action btnExportYears_OnClick;

        //события отбора данных
        event Action CurrentFilter_Changed;

        EducationalInstitution CurrentEducationalInstitution { get; }
        AcademicYear CurrentAcademicYear { get; }

        object PerfomanceDataSource { get; set; }
        object FilterDataSource { get; set; }
        object SelectFilterRow { get; }

        

        void SetEducationalInstitutions(object[] items);
        void SetAcademicYears(object[] items);
    }
}
