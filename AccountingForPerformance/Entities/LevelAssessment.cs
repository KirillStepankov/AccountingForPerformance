using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingForPerformance.Entities
{
    [Serializable]
    public class LevelAssessment
    {
        [DisplayName("Код")]
        public int Id { get; set; }

        [DisplayName("Оценка")]
        public int Assessment { get; set; }
        [Browsable(false)]
        public int AcademicPerformanceId { get; set; }
        [DisplayName("Уровень Оценки")]
        public virtual AcademicPerformance AcademicPerformance { get; set; }

        public override string ToString()
        {
            return $"{Assessment} | {AcademicPerformance.ToString()}";
        }
    }
}
