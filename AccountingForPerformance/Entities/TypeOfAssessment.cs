
using System;
using System.ComponentModel;

namespace AccountingForPerformance.Entities
{
    [Serializable]
    public class TypeOfAssessment
    {
        [DisplayName("Код")]
        public int Id { get; set; }
        [DisplayName("Период")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
