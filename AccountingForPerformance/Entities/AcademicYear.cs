using System;
using System.ComponentModel;

namespace AccountingForPerformance.Entities
{
    [Serializable]
    public class AcademicYear
    {
        [DisplayName("Код")]
        public int Id { get; set; }
        
        [DisplayName("Учебынй год")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
